using Chapter4.ViewModel.Page5ViewModel.LoginSign;

namespace Chapter4.View.Page5Views;

public partial class LoginScreen : ContentPage
{
	private readonly LoginScreenViewModel _loginScreenViewModel;
	public LoginScreen()
	{
		InitializeComponent();
		_loginScreenViewModel = (LoginScreenViewModel)BindingContext;
        _loginScreenViewModel.SignInEvent += _loginScreenViewModel_SignInEvent;
	}

    private async void _loginScreenViewModel_SignInEvent(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DashBordScreen());
    }

   
}
