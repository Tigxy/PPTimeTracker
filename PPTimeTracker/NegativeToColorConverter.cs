using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;


namespace PPTime {
    public class NegativeToColorConverter : IValueConverter {
        public SolidColorBrush FalseColor { get; set; } = Brushes.Black;
        public SolidColorBrush TrueColor { get; set; } = Brushes.Red;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value is int intValue) {
                if (intValue < 0) {
                    return TrueColor;
                }
            }
            return Brushes.Black;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
