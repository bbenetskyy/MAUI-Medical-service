using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MedicalService.Models
{
	public partial class SelectableModel : ObservableObject
    {
        [ObservableProperty] private string _description;
        [ObservableProperty] private bool _isSelected;
	}
}

