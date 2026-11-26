using OmriApp.Views;

namespace OmriApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var navPage = new NavigationPage(new SignUpPage());
            return new Window(navPage);
        }
    }
}