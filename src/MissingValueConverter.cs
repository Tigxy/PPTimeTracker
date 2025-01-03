using System;
using System.Globalization;
using System.Windows.Data;


namespace PPTime {
    public class MissingValueConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            // Ensure the value is an integer
            if (value is double doubleValue) {
                // If the value is smaller 0
                if (doubleValue < 0) {
                    return "?";
                }
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
