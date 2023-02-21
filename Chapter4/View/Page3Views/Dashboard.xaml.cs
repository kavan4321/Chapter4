using Chapter4.Model.Page3Model;
using Chapter4.ViewModel.Page3ViewModel.NickNameCall;

namespace Chapter4.View.Page3Views;

public partial class Dashboard : ContentPage
{
	private readonly DashboardViewModel _dashboardViewModel;
	
    public Dashboard(RegistrationModel registrationModel)
	{
		InitializeComponent();
		_dashboardViewModel = (DashboardViewModel)BindingContext;
		_dashboardViewModel.RegistrationModelDetails = registrationModel;

    }

    private async void ChangeButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void GoButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}