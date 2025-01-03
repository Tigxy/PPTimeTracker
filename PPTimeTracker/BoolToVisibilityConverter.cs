using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;


namespace PPTime {
    public class BoolToVisibilityConverter : IValueConverter {
        public bool Invert { get; set; } = false;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value is bool boolValue) {
                if (Invert)
                    boolValue = !boolValue;
                return boolValue ? Visibility.Visible : Visibility.Hidden;
            }
            return Visibility.Hidden;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
