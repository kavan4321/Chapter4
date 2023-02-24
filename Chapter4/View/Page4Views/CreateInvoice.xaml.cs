using Chapter4.Model.Page4Model;
using Chapter4.ViewModel.Page4ViewModel.CreateDetails;

namespace Chapter4.View.Page4Views;

public partial class CreateInvoice : ContentPage
{
	private readonly CreateInvoiceViewModel _createInvoiceViewModel;
	public CreateInvoice()
	{
		InitializeComponent();
		_createInvoiceViewModel=(CreateInvoiceViewModel)BindingContext;
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
      
        //create object of Details
        CreateInvoiceModel CreateInvoiceDetails = new()
        {
            ProductName =_createInvoiceViewModel.ProductName,
            Quantity=_createInvoiceViewModel.Quantity,
            PurchaseDate= _createInvoiceViewModel.PurchaseDate,
            PurchaseTime= _createInvoiceViewModel.PurchaseTime,
            CustomerName= _createInvoiceViewModel.CustomerName,
            CustomerNumber= _createInvoiceViewModel.CustomerNumber,
            Address= _createInvoiceViewModel.Address,
            Amount= _createInvoiceViewModel.Amount,
            Tax = _createInvoiceViewModel.Tax,
        };
        //navigation to next pagre
        await Navigation.PushAsync(new PrintInvoice(CreateInvoiceDetails));
    }

    private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        _createInvoiceViewModel.Quantity=StepperValue.Value;
    }
}