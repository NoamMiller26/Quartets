namespace Quartets.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		BindingContext = new ViewModels.LoginPagVM();
    }
}