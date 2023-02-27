using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MedicalService.Models
{

    public partial class QuestionableModel : ObservableObject
    {
        [ObservableProperty] private Answer _answer;
		[ObservableProperty] private string _question;
	}
}

