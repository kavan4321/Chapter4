namespace Chapter4.View.Page3Views;

public partial class Welcome : ContentPage
{
	public Welcome()
	{
		InitializeComponent();
	}

    private async void PlayButton_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Registration());
    }
}