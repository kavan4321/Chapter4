using Chapter4.ViewModel.Page5ViewModel.LoginSign;

namespace Chapter4.View.Page5Views;

public partial class LoginScreen : ContentPage
{
	private readonly LoginScreenViewModel _loginScreenViewModel;
	public LoginScreen()
	{
		InitializeComponent();
		_loginScreenViewModel = (LoginScreenViewModel)BindingContext;
	}


    private async void Button_Clicked(object sender, EventArgs e)
    {
		
		    
		if (_loginScreenViewModel.Success==false)
		{
            _loginScreenViewModel.Validation();
		}
		else
		{
			_loginScreenViewModel.Success = false;
            await Navigation.PushAsync(new DashBordScreen());
		}
    }
}
