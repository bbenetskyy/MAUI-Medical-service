using MedicalService.Models;

namespace MedicalService;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    void TapGestureRecognizer_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
		if(e.Parameter is SelectableModel model)
		{
			model.IsSelected = !model.IsSelected;
		}
    }
}


