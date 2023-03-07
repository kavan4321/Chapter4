using Chapter4.ViewModel.Turcks;
namespace Chapter4.View;

public partial class Page2 : ContentPage
{
	private readonly Page2ViewModel _viewModel;
	public Page2()
	{
		InitializeComponent();
        _viewModel = (Page2ViewModel)BindingContext;
	}
}