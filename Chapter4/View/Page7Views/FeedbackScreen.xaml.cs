using Chapter4.Model.Page7Model;
using Chapter4.ViewModel.Page7ViewModel.FoodFeedback;

namespace Chapter4.View.Page7Views;

public partial class FeedbackScreen : ContentPage
{
	private readonly FeedbackViewModel _feedbackViewModel;
	public FeedbackScreen(FoodModel foodModel)
	{
		InitializeComponent();
		_feedbackViewModel=(FeedbackViewModel)BindingContext;
		_feedbackViewModel.FoodModelDetail = foodModel;
	}
}