using OmriApp.Helpers;
using System.Windows.Input;

namespace OmriApp.Views;

public partial class SignUpPage : ContentPage
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
            if (_firstName != value)
            {
                _firstName = value;
                OnPropertyChanged();
            }
        }
    }
    public string LastName
    {
        get => _lastName;
        set
        {
            if (_lastName != value)
            {
                _lastName = value;
                OnPropertyChanged();
            }
        }
    }
    public string UserEmail {
        get => _email;
        set
        {
            if (_email != value)
            {
                _email = value;
                OnPropertyChanged();
            }
        }
    }
    public string UserPassword {
        get => _password;
        set
        {
            if (_password != value)
            {
                _password = value;
                OnPropertyChanged();
            }
        }
    }
    public string Mobile {
        get => _mobile;
        set
        {
            if (_mobile != value)
            {
                _mobile = value;
                OnPropertyChanged();
            }
        }
    }
    public bool EntryAsPassword {
        get => _entryAsPassword;
        set
        {
            if (_entryAsPassword != value)
            {
                _entryAsPassword = value;
                OnPropertyChanged(nameof(EntryAsPassword));
            }
        }
    }
    public string PasswordIconCode {
        get => _passwordIconCode;
        set
        {
            if (_passwordIconCode != value)
            {
                _passwordIconCode = value;
                OnPropertyChanged();
            }
        }
    }
    public ICommand? ShowPasswordCommand { get; }
    public ICommand? SignInCommand { get; }
    public SignUpPage()
	{
		InitializeComponent();
        BindingContext = this;
        _entryAsPassword = true;
        _passwordIconCode = FontHelper.CLOSED_EYE_ICON;
        ShowPasswordCommand = new Command(TogglePasswordButton);
        SignInCommand = new Command(SignUp, Validate);
    }

    private void TogglePasswordButton()
    {
        Passwo.IsPassword = !EntryAsPassword.IsPassword;
        if (EntryAsPassword)
            PasswordIconCode = FontHelper.CLOSED_EYE_ICON;
        else
            PasswordIconCode = FontHelper.OPEN_EYE_ICON;

    }
    private void SignUp()
    {
        //Register user into DB
        //Save User to Current User
        //Go to Main Page
    }
    private bool Validate()
    {
        return true;
    }
}