using OmriApp.Helpers;
using OmriApp.Services;

namespace OmriApp.Views;

public partial class SignInPage : ContentPage
{
    
    private string _username;
    private string _password;
    private bool _entryAsPassword;
    private bool _IsDebugMode => true;
    private DBMokup dBMokup;
    public bool IsSignInButtonEnabled
    {
        get => !string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(UserPassword);
    }

    public string Username
    {
        get => _username;
        set
        {
            if (_username != value)
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
                OnPropertyChanged(nameof(IsSignInButtonEnabled));
            }
        }
    }
    public string UserPassword
    {
        get => _password;
        set
        {
            if (_password != value)
            {
                _password = value;
                OnPropertyChanged(nameof(UserPassword));
                OnPropertyChanged(nameof(IsSignInButtonEnabled));
            }
        }
    }
    public bool EntryAsPassword
    {
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
    public SignInPage()
	{
		InitializeComponent();
        BindingContext = this;
        EntryAsPassword = true;
        dBMokup = new DBMokup();
        if (_IsDebugMode)
        {
            Username = "admin@mail.com";
            UserPassword = "admin";
        }
    }
    void OnTugglePasswordButtonClicked(object sender, EventArgs e)
    {
        var visBtn = sender as Button;
        if (EntryAsPassword)
            visBtn!.Text = FontHelper.CLOSED_EYE_ICON;
        else
            visBtn!.Text = FontHelper.OPEN_EYE_ICON;
        EntryAsPassword = !EntryAsPassword;
    }

    void OnSignInButtonClicked(object sender, EventArgs e)
    {
        if (dBMokup.isExist(Username, UserPassword))
        {
            errorLbl.IsVisible = true;
            errorLbl.Text = "התחברות הצליחה";
        }
        else
        {
            errorLbl.Text = "שם משתמש או סיסמה שגוים";
            //DisplayAlert("Error", "Invalid username or password.", "OK");
        }
    }
}