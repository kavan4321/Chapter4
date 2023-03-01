
using Chapter4.Model.Page6Model;
using Chapter4.ViewModel.Page6ViewModel.Confirms;

namespace Chapter4.View.Page6Views;

public partial class ConfirmScreen : ContentPage
{
	private readonly ConfirmViewModel _confirmViewModel;
	public ConfirmScreen(CardDetails cardDetails)
	{
		InitializeComponent();
        _confirmViewModel = (ConfirmViewModel)BindingContext;
        _confirmViewModel.cardDetails= cardDetails;
	}

    private async void GetIt_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}