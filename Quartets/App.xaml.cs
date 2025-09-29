using Quartets.ModelsLogic;
using Quartets.ModelsLogic;
using Quartets.Views;


namespace Quartets
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            User user = new();
            Page page= user.IsRegistered ? new LoginPage() : new RegisterPage();
            MainPage = page;
        }
    }
}
