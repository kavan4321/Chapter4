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
        _createInvoiceViewModel.InvoiceEvent += _createInvoiceViewModel_InvoiceEvent;
	}

    private void _createInvoiceViewModel_InvoiceEvent(object sender, EventArgs e)
    {
        Methods();
    }

   

    private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        _createInvoiceViewModel.Quantity=StepperValue.Value;
    }


    public async void Methods()
    {
        //create object of Details
        CreateInvoiceModel CreateInvoiceDetails = new()
        {
            ProductName = _createInvoiceViewModel.ProductName,
            Quantity = _createInvoiceViewModel.Quantity,
            PurchaseDate = _createInvoiceViewModel.PurchaseDate.ToString("dd-MMM-yyyy"),
            PurchaseTime = _createInvoiceViewModel.PurchaseTime.ToString(),
            Premium= _createInvoiceViewModel.Premium,
            IsPremium= _createInvoiceViewModel.IsPremium,
            CustomerName = _createInvoiceViewModel.CustomerName,
            CustomerNumber = _createInvoiceViewModel.CustomerNumber,
            Address = _createInvoiceViewModel.Address,
            Amount = _createInvoiceViewModel.Amount,
            Tax = _createInvoiceViewModel.Tax,
        };
        //navigation to next pagre   
        await Navigation.PushAsync(new PrintInvoice(CreateInvoiceDetails));
    }
}