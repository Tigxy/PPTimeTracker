using System;
using System.Globalization;
using System.Windows.Data;

namespace PPTime {
    public class MillisecondsToTimeConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value is int milliseconds) {
                // Convert seconds to TimeSpan
                TimeSpan time = TimeSpan.FromMilliseconds(milliseconds);

                // Return the formatted time string as "hh:mm:ss"
                return time.ToString(@"mm\:ss\,ff");
            }

            return "00:00:00"; // Default format if conversion fails
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException(); // You can implement reverse conversion if needed
        }
    }
}
