using OmriApp.Helpers;
using OmriApp.Services;
using OmriApp.ViewModels;

namespace OmriApp.Views;

public partial class SignInPage : ContentPage
{
    public SignInPage()
	{
		InitializeComponent();
        BindingContext = new SignInViewModel();
    }  
}