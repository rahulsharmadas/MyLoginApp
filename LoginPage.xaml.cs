using MyLoginApp.ViewModels;
namespace MyLoginApp;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel loginViewModel)
	{
		InitializeComponent();
		this.BindingContext = loginViewModel;
		
	}
}