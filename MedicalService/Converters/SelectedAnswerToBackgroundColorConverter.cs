using System.Globalization;
using MedicalService.Models;

namespace MedicalService.Converters
{
    public class SelectedAnswerToBackgroundColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Answer.TryParse(typeof(Answer), value?.ToString(), out var answer)
                && Answer.TryParse(typeof(Answer), parameter?.ToString(), out var requiredAnswer)
                && (Answer)answer == (Answer)requiredAnswer
                ? Color.FromArgb("#6073E7")
                : Colors.Transparent;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}

