using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MedicalService.Models
{
	public partial class SelectableModel : ObservableObject
    {
        [ObservableProperty] public string _description;
        [ObservableProperty] public bool _isSelected;
	}
}

