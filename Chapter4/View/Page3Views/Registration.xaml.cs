using Chapter4.Model.Page3Model;
using Chapter4.ViewModel.Page3ViewModel.QuizRegistration;
using CommunityToolkit.Maui.Alerts;
using System.Globalization;

namespace Chapter4.View.Page3Views;

public partial class Registration : ContentPage
{
    

    public Registration()
	{
		InitializeComponent();
	}


    private void RegisterButton_Clicked(object sender, EventArgs e)
    {
        Register();
    }

    private async void GoBackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    public async void Register()
    {
        string FullName = FullNameEntry.Text;
        string NickName=NickNameEntry.Text;

        RegistrationModel registrationModel = new()
        {
            FullName = FullName,
            NickName = NickName,
        };
        if ((string.IsNullOrEmpty(FullName) || string.IsNullOrWhiteSpace(FullName)) &&
           (string.IsNullOrEmpty(NickName) || string.IsNullOrWhiteSpace(NickName)))
        {
            _ = Toast.Make("Please Enter Your Full Name and Nick Name", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
        }
        else if (string.IsNullOrEmpty(FullName) || string.IsNullOrWhiteSpace(FullName))
        {
            _ = Toast.Make("Please Enter Your Full Name", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
        }
        else if (string.IsNullOrEmpty(NickName) || string.IsNullOrWhiteSpace(NickName))
        {
            _ = Toast.Make("Please Enter Your Nick Name", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
        }
        else
        {
            await Navigation.PushAsync(new Dashboard(registrationModel));
        }

    }

}