using Chapter4.ViewModel.Page6ViewModel.SelectMethod;

namespace Chapter4.View.Page6Views;

public partial class PaymentMethod : ContentPage
{
	private readonly PaymentMethodViewModel _viewModel;
	public PaymentMethod()
	{
		InitializeComponent();
		_viewModel=(PaymentMethodViewModel)BindingContext;
        _viewModel.CreditCardChanged += _viewModelCreditCardChanged;
        _viewModel.DebitCardChanged += _viewModelDebitCardChanged;
        _viewModel.GpayChanged += _viewModelGpayChanged;
	}

    private async void _viewModelCreditCardChanged(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreditCardScreen());
    }
    private async void _viewModelDebitCardChanged(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DebitCardScreen());
    }
    private async void _viewModelGpayChanged(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GpayScreen());
    }

   

   
}