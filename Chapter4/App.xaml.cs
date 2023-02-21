namespace Chapter4;
using View;
using View.Page3Views;
using View.Page4Views;
public partial class App : Application
{
	public App()
	{
		InitializeComponent();	

        MainPage = new NavigationPage(new CreateInvoice());
    }
}
