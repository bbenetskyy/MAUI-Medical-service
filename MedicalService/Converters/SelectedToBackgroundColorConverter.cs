using System;
using System.Globalization;

namespace MedicalService.Converters
{
    public class SelectedToBackgroundColorConverter : IValueConverter
	{

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return bool.TryParse(value?.ToString(), out var selected) && selected
                ? Color.FromArgb("#6073E7")
                : Colors.Transparent;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}

