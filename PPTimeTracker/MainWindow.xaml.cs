using PPTimeTracker;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace PPTime {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged {
        public CLIPresentation Presentation { get; private set; }

        public ObservableCollection<OpenPresentation> OpenPresentations { get; private set; } = new ObservableCollection<OpenPresentation>();
        private OpenPresentation? _selectedPresentation;

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        private CancellationTokenSource _cts = new();
        private Task _previousTask;

        public OpenPresentation? SelectedPresentation {
            get {
                return _selectedPresentation;
            }
            set {
                if (_selectedPresentation != value) {
                    _selectedPresentation = value;
                    OnPropertyChanged(nameof(SelectedPresentation));
                }
            }
        }

        public MainWindow() {
            InitializeComponent();
            Presentation = new CLIPresentation();
            this.DataContext = this;
            RefreshPresentations(false);
        }

        private void RefreshPresentations(bool showUserMessages = true) {
            OpenPresentation? previouslySelectedPresentation = SelectedPresentation;
            SelectedPresentation = default;

            List<OpenPresentation> openPresentations = PPUtils.GetOpenPresentations();
            if (openPresentations.Count > 0) {
                // iterate from back to front to not cause indexing errors
                for (int i = OpenPresentations.Count - 1; i >= 0; i--) {
                    var presentation = OpenPresentations[i];
                    if (!openPresentations.Contains(presentation)) {
                        OpenPresentations.RemoveAt(i);
                    }
                }

                foreach (var presentation in openPresentations) {
                    // don't do anything if presentation is already in list
                    if (OpenPresentations.Contains(presentation)) { }
                    // add it if it is not
                    else if (!OpenPresentations.Contains(presentation)) {
                        OpenPresentations.Add(presentation);
                    }
                }
                if (previouslySelectedPresentation != default) {
                    if (OpenPresentations.Contains(previouslySelectedPresentation)) {
                        SelectedPresentation = previouslySelectedPresentation;
                    }
                    else {
                        SelectedPresentation = default;
                    }
                }
                if (previouslySelectedPresentation == default && OpenPresentations.Count > 0) {
                    SelectedPresentation = OpenPresentations.FirstOrDefault();
                }
            }
            else {
                SelectedPresentation = default;
                if (showUserMessages) {
                    Debug.WriteLine("PowerPoint is not running or there is no open presentation.");
                    MessageBox.Show("Es wurden keine geöffneten PowerPoint-Dateien gefunden.");
                }
            }
        }

        private async void ReloadPresentation() {
            if (SelectedPresentation != default) {
                Presentation.PresentationPath = SelectedPresentation?.Path;
                _cts.Cancel();
                try {
                    if (_previousTask != default) {
                        await _previousTask;

                        // minor delay to ensure previous ui calls ended as well
                        await Task.Delay(150);
                    }
                }
                catch (OperationCanceledException) {
                    Debug.WriteLine("Previous task canceled.");
                }
                finally {
                    _cts.Dispose();
                    _cts = new CancellationTokenSource();
                }

                _previousTask = Task.Run(() => Presentation.Reload(_cts.Token), _cts.Token);
            }
            else {
                Presentation.Reset();
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e) {
            RefreshPresentations();
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e) {
            Process.Start(new ProcessStartInfo {
                FileName = e.Uri.ToString(),
                UseShellExecute = true
            });
        }

        private void cbOpenPowerpoints_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e) {
            ReloadPresentation();
        }
    }
}
