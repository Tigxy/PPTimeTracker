using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Xml;
using System.Xml.Serialization;

namespace PPTime {
    public class Presentation : INotifyPropertyChanged {

        private string? _presentationPath;
        private string? _presentationName;
        private int _totalDuration;
        private int _anyValueNotFound;

        public string? PresentationPath {
            get {
                return _presentationPath;
            }
            set {
                if (_presentationPath != value) { 
                    _presentationPath = value;
                    OnPropertyChanged(nameof(PresentationPath));

                    if (value != null) {
                        // update also file name
                        PresentationName = Path.GetFileName(_presentationPath);
                    }
                }
            }
        }

        public string? PresentationName {
            get {
                return _presentationName;
            }
            private set {
                if (_presentationName != value) {
                    _presentationName = value;
                    OnPropertyChanged(nameof(PresentationName));
                }
            }
        }

        public int TotalDuration {
            get {
                return _totalDuration;
            }
            private set {
                if (_totalDuration != value) {
                    _totalDuration = value;
                    OnPropertyChanged(nameof(TotalDuration));
                }
            }
        }

        /// <summary>
        /// < 0 if not all values have been found
        /// </summary>
        public int AnyValueNotFound {
            get {
                return _anyValueNotFound;
            }
            private set {
                if (_anyValueNotFound != value) {
                    _anyValueNotFound = value;
                    OnPropertyChanged(nameof(AnyValueNotFound));
                }
            }
        }

        public ObservableCollection<Slide> Slides { get; private set; } = new ();

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public void Reload() {
            if (PresentationPath == null)
                return;

            var slides = ParsePresentation(PresentationPath);
            Slides.Clear();
            if (slides != null) {
                foreach (var slide in slides) {
                    Slides.Add(slide);
                }

                TotalDuration = Slides.Where(s => s.IsVisible).Sum(s => s.TotalDuration);
                AnyValueNotFound = Slides.Where(s => s.IsVisible).Sum(s => s.AnyValueNotFound);
            }
        }

        private Slide[]? ParsePresentation(string file) {
            if (!File.Exists(file)) {
                MessageBox.Show("Präsentation existiert nicht (mehr)!");
                return default;
            }

            bool hadErrorLoadingSlides = false;
            List<Slide> slides = new();
            try {
                using (ZipArchive archive = ZipFile.OpenRead(file)) {
                    foreach (ZipArchiveEntry entry in archive.Entries) {
                        System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^ppt/slides/slide(\d+).xml$");
                        var mobj = regex.Match(entry.FullName);
                        if (mobj != null && mobj.Success) {
                            // determine slide number based on slide name,
                            // as they might not be retrieved in an ordered fashion
                            int slideNumber = Convert.ToInt32(mobj.Groups[1].Value);

                            // determine location where to extract file
                            string fileName = Path.GetRandomFileName();

                            // temporarily extract file
                            entry.ExtractToFile(fileName);

                            Slide slide;
                            try {
                                // parse slide
                                slide = ParseSlide(fileName, slideNumber);
                            }
                            catch (Exception) {
                                slide = new Slide() { SlideNumber=slideNumber };
                                hadErrorLoadingSlides = true;
                            }
                            finally {
                                // delete temporary file right away, so that we don't bloat our system
                                File.Delete(fileName);
                            }

                            // store slide
                            slides.Add(slide);
                        }
                    }

                    if (hadErrorLoadingSlides)
                        MessageBox.Show("Einige Folien konnten nicht richtig geladen werden.");
                }
            }
            catch (NotSupportedException ex) {
                MessageBox.Show("Datei wird nicht unterstützt!");
                return default;
            }
            catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException) {
                MessageBox.Show("Konnte nicht auf Präsentation zugreifen. Versuch's erneut!");
                return default;
            }
            catch {
                MessageBox.Show("Ein unerwarteter Fehler ist aufgetreten!");
                return default;
            }

            return slides.OrderBy(s => s.SlideNumber).ToArray();
        }

        private static Slide ParseSlide(string file, int slideNumber) {
            // Call the method to parse the XML
            sld sldObject = ParseXml(file);

            // ensure that some animations exist
            var groups = sldObject.timing?.tnLst?.par?.cTn?.childTnLst?.seq?.cTn?.childTnLst;
            List<AnimationGroup> animationGroups = new List<AnimationGroup>();
            if (groups != null) {
                foreach (var group in groups) {
                    animationGroups.Add(new AnimationGroup() {
                        Animations = group.cTn.childTnLst.par.cTn.childTnLst.Select(a => new Animation() {
                            Delay = a.cTn.stCondLst.cond.delay,
                            Duration = GetAnimationDuration(a.cTn.childTnLst.Items)
                        }).ToArray()
                    });
                }
            }
            var (duration, transition) = GetDurationAndTransitionTime(sldObject);

            return new Slide() {
                AnimationGroups = animationGroups.ToArray(),
                TransitionDuration = transition,
                Duration = duration,
                SlideNumber = slideNumber,
                IsVisible = sldObject.show > 0
            };
        }

        private static (int, int) GetDurationAndTransitionTime(sld sldObject) {
            var c = sldObject.AlternateContent?.Choice;
            if (c is not null && c.Length > 0) {
                var cc = c[0] as System.Xml.XmlNode[];
                var attributes = cc
                    .Where(ci => ci.Name == "p:transition")
                    .FirstOrDefault()
                    ?.Attributes
                    .Cast<XmlAttribute>();

                var dur_value = attributes
                    .FirstOrDefault(a => a.Name.Contains("dur"))
                    ?.Value;
                if (dur_value == null) {
                    var dur_str = attributes
                        .FirstOrDefault(a => a.Name.Contains("spd"))
                        ?.Value;

                    dur_value = dur_str switch {
                        "slow" => "1000",
                        _ => "-1"  // failed to parse
                    };
                }

                var trans_value = attributes
                    .FirstOrDefault(a => a.Name.Contains("advTm"))
                    ?.Value ?? "0";

                return (Convert.ToInt32(dur_value), Convert.ToInt32(trans_value));
            }
            return (-1, -1);
        }

        public static int GetAnimationDuration(object d) {
            var durations = new[] { 0 };
            if (d is object[] dd) {
                durations = dd.Select(di => {
                    int? duration = null;

                    var d1 = ParseObjectToDictionary(di);
                    object cBhvr;
                    if (d1.TryGetValue("cBhvr", out cBhvr)) {
                        var d2 = ParseObjectToDictionary(cBhvr);
                        object cTn;
                        if (d2.TryGetValue("cTn", out cTn)) {
                            var d3 = ParseObjectToDictionary(cTn);
                            object dur;
                            _ = d3.TryGetValue("dur", out dur);
                            duration = Convert.ToInt32(dur);
                        }
                    }
                    return duration ?? 0;
                }).ToArray();
            }
            //return GetMostFrequentElement(durations);
            return durations.Max();
        }

        // Method to parse the XML and deserialize it into an object of type Sld
        public static sld ParseXml(string filePath) {
            XmlSerializer serializer = new XmlSerializer(typeof(sld));

            // Open the file and deserialize the XML into the Sld object
            using (StreamReader reader = new StreamReader(filePath)) {
                return (sld)serializer.Deserialize(reader);
            }
        }


        // Method to parse an object into key-value pairs
        public static Dictionary<string, object> ParseObjectToDictionary(object obj) {
            // Dictionary to hold the key-value pairs
            Dictionary<string, object> keyValuePairs = new Dictionary<string, object>();

            // Get the type of the object
            Type type = obj.GetType();

            // Get all properties of the object
            PropertyInfo[] properties = type.GetProperties();

            foreach (var property in properties) {
                // Get the property name
                string propertyName = property.Name;

                // Get the property value
                object propertyValue = property.GetValue(obj);

                // Add the property name and value to the dictionary
                keyValuePairs.Add(propertyName, propertyValue);
            }

            return keyValuePairs;
        }

        // Method to safely get a property value or return null if the property doesn't exist
        public static object GetSafePropertyValue(object obj, string propertyName) {
            try {
                // Get the object's type
                Type type = obj.GetType();

                // Get the property by name
                PropertyInfo property = type.GetProperty(propertyName);

                // If the property doesn't exist, return null
                if (property == null)
                    return null;

                // Get the value of the property
                return property.GetValue(obj);
            }
            catch {
                // In case of any failure (e.g., reflection error), return null
                return null;
            }
        }

        public static T GetMostFrequentElement<T>(IEnumerable<T> e) {
            return e.GroupBy(x => x)
                       .OrderByDescending(g => g.Count())
                       .First()
                       .Key;
        }


    }
}
