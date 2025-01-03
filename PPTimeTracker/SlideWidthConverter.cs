using System;
using System.Globalization;
using System.Windows.Data;

namespace PPTime {
    public class SlideWidthConverter : IValueConverter {
        public float Min { get; set; } = 0;
        public float Max { get; set; } = 10000;
        public float Scaling { get; set; } = 1;

        public SlideWidthConverter() { }

        public SlideWidthConverter(float minimum = 10, float maximum = 1000, float scaling = 1) {
            Min = minimum;
            Max = maximum;
            Scaling = scaling;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {

            var a = 2;
            if (value is int input) {
                float newValue = Math.Clamp((float)input * Scaling, Min, Max);
                return (int)newValue;
            }
            throw new InvalidOperationException("Value must be a double.");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}