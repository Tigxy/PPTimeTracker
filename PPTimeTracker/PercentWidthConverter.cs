using System;
using System.Globalization;
using System.Windows.Data;


namespace PPTime {
    public class PercentWidthConverter : IMultiValueConverter {
        public object? Convert(object[] values, Type targetType, object parameter, CultureInfo culture) {
            double? availableWidth = (values[0] as double?) ?? (double?)(values[0] as int?);
            double? measure = (values[1] as double?) ?? (double?)(values[1] as int?);
            double? reference = (values[2] as double?) ?? (double?)(values[2] as int?);

            if (availableWidth == default || measure == default || reference == default)
                throw new InvalidOperationException("Values of wrong type.");

            if (reference == 0)
                return 0.0;

            double? newWidth = availableWidth * (measure / reference);
            return Math.Max(0, (double)newWidth);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
