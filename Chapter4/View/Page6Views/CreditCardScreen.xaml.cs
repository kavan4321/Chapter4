using Chapter4.Model.Page6Model;
using Chapter4.ViewModel.Page6ViewModel.Credits;

namespace Chapter4.View.Page6Views;

public partial class CreditCardScreen : ContentPage
{
	private readonly CreditViewModel _viewModel;
	public CreditCardScreen()
	{
		InitializeComponent();
		_viewModel=(CreditViewModel)BindingContext;
        _viewModel.PayEvent += _viewModelPayEvent;
	}

    private void _viewModelPayEvent(object sender, EventArgs e)
    {
        PayDetails();
    }

    private async void ImageButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();    
    }

    private void EntryTextChanged(object sender, TextChangedEventArgs e)
    {
        _viewModel.DisplayText();
    }

    public async void PayDetails()
    {
        CreditModel creditModel = new()
        {
            Amount = _viewModel.Amount,
            Method = "Debit card"
        };
        await Navigation.PushAsync(new ConfirmScreen(creditModel));
    }
}