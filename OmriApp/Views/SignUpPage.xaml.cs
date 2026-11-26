using OmriApp.Helpers;
using OmriApp.ViewModels;
using System.Windows.Input;

namespace OmriApp.Views;

public partial class SignUpPage : ContentPage
{
    public SignUpPage()
	{
		InitializeComponent();
        BindingContext = new SignUpPageViewModel(this.Navigation);
    }
}