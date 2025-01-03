using System;
using System.Linq;

namespace PPTime {

    public class Slide {
        public int SlideNumber { get; set; }
        public int TransitionDuration { get; set; } = -1;
        public double TransitionDurationInSeconds => TransitionDuration / 1000.0;
        public int NextSlideAfter { get; set; } = -1;
        public double NextSlideAfterInSeconds => NextSlideAfter / 1000.0;
        public bool IsVisible { get; set; }

        public AnimationGroup[]? AnimationGroups { get; set; } = null;
        public int AnimationDuration => AnimationGroups?.Sum(g => g.Duration) ?? -1;
        public double AnimationDurationInSeconds => AnimationDuration / 1000.0;

        public int TotalDuration => Math.Max(0, TransitionDuration) + Math.Max(Math.Max(0, NextSlideAfter), Math.Max(0, AnimationDuration));
        public double TotalDurationInSeconds => TotalDuration / 1000.0;

        // -1 if something is missing
        public int AnyValueNotFound => TransitionDuration < 0 || NextSlideAfter < 0 || AnimationDuration < 0 ? -1 : 0;

        public int CumulativeTotalDuration { get; set; }
        public bool IsLastSlide { get; set; }
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
