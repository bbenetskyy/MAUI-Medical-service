using System.Globalization;

namespace MedicalService.Converters
{
    public class SelectedToTextColorConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return bool.TryParse(value?.ToString(), out var selected) && selected
                ? Color.FromArgb("#F4FCFF")
                : Color.FromArgb("#777777");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}

