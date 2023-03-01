using Chapter4.Model.Page7Model;
using Chapter4.ViewModel.Page7ViewModel.Foods;

namespace Chapter4.View.Page7Views;

public partial class FoodScreen : ContentPage
{
	private readonly FoodViewModel _viewModel;

	public FoodScreen()
	{
		InitializeComponent();

		_viewModel=(FoodViewModel)BindingContext;
        _viewModel.NextCommandChanged += ViewModelNextCommandChanged;
        _viewModel.ValueChange();
    }

    private async void ViewModelNextCommandChanged(object sender, EventArgs e)
    {

        FoodModel foodModel = new()
        {
            GetImageSource = _viewModel.GetImageSource,
            GetColor = _viewModel.GetColor,
            DisplayMood = _viewModel.DisplayMood
        };
        await Navigation.PushAsync(new FeedbackScreen(foodModel));
    }

    private void SliderValueChanged(object sender, ValueChangedEventArgs e)
    {
		_viewModel.ValueChange();
    }
}