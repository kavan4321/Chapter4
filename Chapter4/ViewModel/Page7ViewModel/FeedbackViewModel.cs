
using Chapter4.Model.Page7Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Chapter4.ViewModel.Page7ViewModel.FoodFeedback
{
    public class FeedbackViewModel : INotifyPropertyChanged
    {
        
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private FoodModel _foodModel;
        public FoodModel FoodModelDetail
        {
            get { return _foodModel; }
            set
            {
                _foodModel= value;
                OnPropertyChanged();
            }
        }
    }
}
