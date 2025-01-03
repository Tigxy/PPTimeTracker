using System;
using System.Diagnostics;
using System.Windows;

namespace PPTime {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public Presentation Presentation { get; private set; }

        public MainWindow() {
            InitializeComponent();

            Presentation = new Presentation();
            this.DataContext = Presentation;
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e) {
            Presentation.Reload();
        }

        private void btnSelectFile_Click(object sender, RoutedEventArgs e) {
            var dialog = new Microsoft.Win32.OpenFileDialog {
                DefaultExt = ".pptx",
                Filter = "PowerPoint Files (*.pptx;*.ppt)|*.pptx;*.ppt",
                Title = "Select a PowerPoint File",
                InitialDirectory = System.IO.Path.GetDirectoryName(Presentation.PresentationPath)
            };

            // Show open file dialog box
            bool? result = dialog.ShowDialog();

            // Process open file dialog box results
            if (result == true) {
                Presentation.PresentationPath = dialog.FileName;
                Presentation.Reload();
            }
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e) {
            System.Diagnostics.Process.Start(new ProcessStartInfo {
                FileName = e.Uri.ToString(),
                UseShellExecute = true
            });
        }
    }
}
