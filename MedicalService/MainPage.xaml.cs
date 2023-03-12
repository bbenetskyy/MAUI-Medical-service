using MedicalService.Models;

namespace MedicalService;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
		if (e.Parameter is SelectableModel selectable)
		{
			selectable.IsSelected = !selectable.IsSelected;
		}
		else if (e.Parameter is QuestionableModel questionable)
		{
			var frame = sender as Frame;
			var label = frame.Children.First() as Label;
			questionable.Answer = label.Text.Equals("yes", StringComparison.InvariantCultureIgnoreCase)
				? Answer.Yes
				: Answer.No;
		}
    }
}


