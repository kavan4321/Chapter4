using Chapter4.Model.Page6Model;
using Chapter4.ViewModel.Page6ViewModel.Debits;

namespace Chapter4.View.Page6Views;

public partial class DebitCardScreen : ContentPage
{
    private readonly DebitViewModel _debitViewModel;
	public DebitCardScreen()
	{
		InitializeComponent();
        _debitViewModel=(DebitViewModel)BindingContext;
        _debitViewModel.PayCompleted += DebitViewModelPayCompleted;
	}

    private void DebitViewModelPayCompleted(object sender, EventArgs e)
    {
        PayDetails();
    }

    private void EntryTextChanged(object sender, TextChangedEventArgs e)
    {
        _debitViewModel.DisplayValue();
    }
    private void DatePickerDateSelected(object sender, DateChangedEventArgs e)
    {
        _debitViewModel.Display();
    }

    public async void PayDetails()
    {
        CardDetails cardDetails = new()
        {
            Amount = _debitViewModel.Amount,
            Method = "Debit card"
        };
        await Navigation.PushAsync(new ConfirmScreen(cardDetails));
    }

    private async void ImageButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}