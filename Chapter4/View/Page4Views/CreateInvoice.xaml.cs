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
}