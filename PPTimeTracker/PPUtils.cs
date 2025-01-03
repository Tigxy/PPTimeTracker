using Microsoft.Office.Interop.PowerPoint;
using System.Collections.Generic;
using System.Runtime.InteropServices;

//using System.Windows;

namespace PPTimeTracker {
    internal class PPUtils {
        public static List<OpenPresentation> GetOpenPresentations() {
            try {
                // Attach to the active PowerPoint application
                Application pptApplication = (Application)Marshal2.GetActiveObject("PowerPoint.Application");

                List<OpenPresentation> presentations = new();

                // Check if there are any open presentations
                if (pptApplication.Presentations.Count > 0) {

                    // Loop through each presentation
                    foreach (Presentation presentation in pptApplication.Presentations) {
                        presentations.Add(new OpenPresentation() {
                            Name = presentation.Name,
                            Path = presentation.FullName
                        });
                    }
                };
                return presentations;
            }
            catch (COMException) {
                return new List<OpenPresentation>();
            }
        }
    }
}
