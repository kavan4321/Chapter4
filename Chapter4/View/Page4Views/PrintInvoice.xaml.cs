using Chapter4.Model.Page4Model;
using Chapter4.ViewModel.Page4ViewModel.PrintDetails;
namespace Chapter4.View.Page4Views;

public partial class PrintInvoice : ContentPage
{

	private readonly PrintInvoiceViewModel _printInvoiceViewModel;

	public PrintInvoice(CreateInvoiceModel createInvoiceModel)
	{
		InitializeComponent();
		_printInvoiceViewModel = (PrintInvoiceViewModel)BindingContext;
		_printInvoiceViewModel.CreateInvoiceDetails = createInvoiceModel;
	}
}