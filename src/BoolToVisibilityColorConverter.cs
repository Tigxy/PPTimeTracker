using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;


namespace PPTime {
    public class BoolToVisibilityColorConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            // Ensure the value is an integer
            if (value is bool boolValue) {

                if (boolValue) {
                    return Brushes.Transparent;
                }
            }

            // Not active
            return Brushes.LightGray;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
