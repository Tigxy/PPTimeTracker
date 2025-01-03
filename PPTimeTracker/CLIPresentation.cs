using Microsoft.Office.Core;
using PPTime;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using pp = Microsoft.Office.Interop.PowerPoint;


namespace PPTimeTracker {
    public class CLIPresentation : BasePresentation {
        public override void Reset() {
            Slides.Clear();
            PresentationPath = default;
            TotalDuration = 0;
            AnyValueNotFound = 0;
        }

        public async override void Reload(CancellationToken token) {
            // Ensure UI thread access
            await System.Windows.Application.Current.Dispatcher.BeginInvoke(() => {
                // clear all slides
                Slides.Clear();
                TotalDuration = 0;
                AnyValueNotFound = 1;
            });

            try {
                // Attach to the active PowerPoint application
                pp.Application pptApplication = (pp.Application)Marshal2.GetActiveObject("PowerPoint.Application");

                // Try finding selected presentation
                pp.Presentation? presentation = default;
                foreach (pp.Presentation p in pptApplication.Presentations)
                    if (p.FullName == PresentationPath)
                        presentation = p;

                // Process presentation
                if (presentation != default) {

                    int cumulativeDuration = 0;

                    foreach (pp.Slide slide in presentation.Slides) {
                        token.ThrowIfCancellationRequested();
                        var transition = slide.SlideShowTransition;
                        Slide timeSlide = new() {
                            SlideNumber = slide.SlideNumber,
                            IsVisible = transition.Hidden == MsoTriState.msoFalse,
                            NextSlideAfter = transition.AdvanceOnTime == MsoTriState.msoTrue ? (int)(transition.AdvanceTime * 1000) : -1,
                            TransitionDuration = transition.EntryEffect != pp.PpEntryEffect.ppEffectNone ? (int)(transition.Duration * 1000) : 0
                        };

                        List<AnimationGroup> animationGroups = new();
                        List<Animation> animations = new();
                        foreach (pp.Effect effect in slide.TimeLine.MainSequence) {

                            // store animations to group if they 
                            if (effect.Timing.TriggerType != pp.MsoAnimTriggerType.msoAnimTriggerWithPrevious
                                && animations.Count > 0) {
                                animationGroups.Add(new AnimationGroup() { Animations = animations.ToArray() });
                                animations.Clear();
                            }

                            var effectDuration = effect.Timing.Duration;
                            if (effect.EffectType == pp.MsoAnimEffect.msoAnimEffectAppear && effect.TextRangeLength > 1) {
                                effectDuration = -1;
                            }

                            animations.Add(new Animation() {
                                Delay = (int)(effect.Timing.TriggerDelayTime * 1000),
                                Duration = (int)(effectDuration * 1000)
                            });
                        }

                        // add all remaining animations
                        if (animations.Count > 0)
                            animationGroups.Add(new AnimationGroup() { Animations = animations.ToArray() });

                        timeSlide.AnimationGroups = animationGroups.ToArray();

                        if (timeSlide.IsVisible) {
                            cumulativeDuration += timeSlide.TotalDuration;
                        }
                        timeSlide.CumulativeTotalDuration = cumulativeDuration;
                        timeSlide.IsLastSlide = timeSlide.SlideNumber == presentation.Slides.Count;

                        // Ensure UI thread access
                        await System.Windows.Application.Current.Dispatcher.BeginInvoke(() => {
                            if (timeSlide.IsVisible) {
                                TotalDuration += timeSlide.TotalDuration;
                                AnyValueNotFound += timeSlide.AnyValueNotFound;
                            }
                            this.Slides.Add(timeSlide);
                        });
                    }
                }
                else {
                    System.Windows.MessageBox.Show("Ausgewählte PowerPoint nicht mehr verfügbar.");
                }
            }
            catch (COMException) {
                System.Windows.MessageBox.Show("Unerwarteter Fehler: Es konnten keine Details für die PowerPoint geladen werden.");
            }
            catch (OperationCanceledException) {
                Debug.WriteLine("Reload() canceled.");
            }

            TotalDuration = Slides.Where(s => s.IsVisible).Sum(s => s.TotalDuration);
            AnyValueNotFound = Slides.Where(s => s.IsVisible).Sum(s => s.AnyValueNotFound);
        }
    }
}
