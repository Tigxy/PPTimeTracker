using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;


namespace PPTime {
    public class ValueToColorConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            // Ensure the value is an integer
            if (value is int intValue) {
                // If the value is smaller 0, return Red
                if (intValue < 0) {
                    return Brushes.Red;
                }
            }

            // Return default color (Black) if value is not -1
            return Brushes.Black;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
