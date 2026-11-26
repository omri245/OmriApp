using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using OmriApp.Helpers;
using OmriApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OmriApp.ViewModels
{
    public partial class SignUpPageViewModel : ObservableObject
    {
        INavigation _navigation;
        private string? _firstName;
        private string? _lastName;
        private string? _email;
        private string? _password;
        private string? _mobile;

        [ObservableProperty]
        private bool _entryAsPassword;

        [ObservableProperty]
        private string? _passwordIconCode;

        [ObservableProperty]
        private string? _errorMessage;

        public ICommand? ShowPasswordCommand { get; }
        public ICommand? GoToSignIpCommand { get; }

        public SignUpPageViewModel(INavigation navigation)
        {
            GoToSignIpCommand = new Command(async () => await _navigation!.PushAsync(new SignUpPage()));
            EntryAsPassword = true;
            PasswordIconCode = FontHelper.OPEN_EYE_ICON;
            ShowPasswordCommand = new Command(() =>
            {
                if (EntryAsPassword)
                    PasswordIconCode = FontHelper.CLOSED_EYE_ICON;
                else
                    PasswordIconCode = FontHelper.OPEN_EYE_ICON;
                EntryAsPassword = !EntryAsPassword;
            });
            _navigation = navigation;
        }
        [RelayCommand]
        private void SignUp()
        {
            try
            {
                //IsBusy = true; //Show lock screen
                //Task.Delay(5000);

                //IsBusy = false;
                ErrorMessage = "GoToMainPage";
            }
            catch (Exception ex)
            {
                //IsBusy = false;
                ErrorMessage = ex.Message;
                //await Shell.Current.DisplayAlert("SignUp",ex.Message, "Cancel");
            }
        }

        private bool Validate()
        {
            return true;
        }
    }
}
