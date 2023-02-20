using Chapter4.ViewModel.Train;

namespace Chapter4.View;

public partial class Page1 : ContentPage
{
	private Page1ViewModel _page1ViewModel;
	public Page1()
	{
		InitializeComponent();
        _page1ViewModel = (Page1ViewModel)BindingContext;

    }
}