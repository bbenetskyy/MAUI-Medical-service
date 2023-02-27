using System.Globalization;
using MedicalService.Models;

namespace MedicalService.Converters
{
    public class SelectedAnswerToTextColorConverter : IValueConverter
    {
        public Answer RequiredAnswer { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Answer.TryParse(typeof(Answer), value?.ToString(), out var answer)
                && Answer.TryParse(typeof(Answer), parameter?.ToString(), out var requiredAnswer)
                && (Answer)answer == (Answer)requiredAnswer
                ? Color.FromArgb("#F4FCFF")
                : Color.FromArgb("#777777");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}

