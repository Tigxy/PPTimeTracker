using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;


namespace PPTime {
    public class ConditionalColorConverter : IMultiValueConverter {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture) {
            bool condition = (bool)values[1];
            if (condition)
                return values[0];
            return Brushes.Transparent;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
