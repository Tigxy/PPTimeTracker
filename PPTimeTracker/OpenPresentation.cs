namespace PPTimeTracker {
    public class OpenPresentation {
        public string Name { get; set; }
        public string Path { get; set; }

        public override bool Equals(object? obj) {
            if (obj is OpenPresentation openPres) {
                return openPres.Path == this.Path;
            }
            return false;
        }
    }
}