using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmriApp.ViewModels
{
    internal class SignUpPageViewModel : ContentPage
    {
        private string? _firstName;
        private string? _lastName;
        private string? _email;
        private string? _password;
        private string? _mobile;
        private bool _entryAsPassword;
        private string? _passwordIconCode;

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (_firstName != value )
{
                    _firstName = value;
                    OnPropertyChanged();
                }
            }
        }
        public string LastName {
            get => _firstName;
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
