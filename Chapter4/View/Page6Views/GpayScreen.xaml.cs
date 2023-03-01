using Chapter4.Model.Page6Model;
using Chapter4.ViewModel.Page6ViewModel.Gpays;

namespace Chapter4.View.Page6Views;

public partial class GpayScreen : ContentPage
{
	private readonly GpayViewModel _gpayViewModel;
	public GpayScreen()
	{
		InitializeComponent();
		_gpayViewModel=(GpayViewModel)BindingContext;
        _gpayViewModel.PayCommandChanged += GpayViewModelPayCommandChanged;
	}

    private void GpayViewModelPayCommandChanged(object sender, EventArgs e)
    {
        PayMethod();
    }

    private void EntryTextChanged(object sender, TextChangedEventArgs e)
    {
        _gpayViewModel.DisplayValue();
    }

    public async void PayMethod()
    {
        CardDetails cardDetails = new()
        {
            Amount = _gpayViewModel.Amount,
            Method = "Gpay"
        };
        await Navigation.PushAsync(new ConfirmScreen(cardDetails));
    }
}