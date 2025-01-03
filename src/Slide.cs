using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPTime {
    public class SlideContainer {


        public Slide[] Slides { get; set; }
    }

    public class Slide {
        public int SlideNumber { get; set; }
        public int Duration { get; set; } = -1;
        public double DurationInSeconds => Duration / 1000.0;
        public int TransitionDuration { get; set; } = -1;
        public double TransitionDurationInSeconds => TransitionDuration / 1000.0;
        public bool IsVisible { get; set; }

        public AnimationGroup[]? AnimationGroups { get; set; } = null;
        public int AnimationDuration => AnimationGroups?.Sum(g => g.Duration) ?? -1;
        public double AnimationDurationInSeconds => AnimationDuration / 1000.0;

        public int TotalDuration => Math.Max(0, Duration) + Math.Max(Math.Max(0, TransitionDuration), Math.Max(0, AnimationDuration));
        public double TotalDurationInSeconds => TotalDuration / 1000.0;

        // -1 if something is missing
        public int AnyValueNotFound => Duration < 0 || TransitionDuration < 0 || AnimationDuration < 0 ? -1 : 0;
    }

    public class AnimationGroup {
        public Animation[]? Animations { get; set; } = null;
        public int Duration => Animations?.Select(a => a.Duration + a.Delay).Max() ?? 0;
    }

    public class Animation {
        public int Duration { get; set; }
        public int Delay { get; set; }
    }
}
