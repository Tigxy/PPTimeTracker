﻿using PPTime;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Threading;

namespace PPTimeTracker {
    public abstract class BasePresentation : INotifyPropertyChanged {

        private string? _presentationPath;
        private string? _presentationName;
        private int _totalDuration;
        private int _countValuesNotFound;

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
            internal set {
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
            internal set {
                if (_totalDuration != value) {
                    _totalDuration = value;
                    OnPropertyChanged(nameof(TotalDuration));
                }
            }
        }

        /// <summary>
        /// < 0 if not all values have been found
        /// </summary>
        public int CountValuesNotFound {
            get {
                return _countValuesNotFound;
            }
            internal set {
                if (_countValuesNotFound != value) {
                    _countValuesNotFound = value;
                    OnPropertyChanged(nameof(CountValuesNotFound));
                    OnPropertyChanged(nameof(AnyValueNotFound));
                }
            }
        }
        public bool AnyValueNotFound => CountValuesNotFound > 0;

        public ObservableCollection<Slide> Slides { get; internal set; } = new();

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public abstract void Reset();
        public abstract void Reload(CancellationToken token);
    }
}
