
using Chapter4.View.Page7Views;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Chapter4.ViewModel.Page7ViewModel.Foods
{
    public class FoodViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string _displayMood;
        public string DisplayMood
        {
            get { return _displayMood; }
            set { 
                _displayMood = value;
                OnPropertyChanged();
               }
        }


        private ImageSource _imageSource;
        public ImageSource GetImageSource
        {
            get { return _imageSource; }
            set { _imageSource = value;
                OnPropertyChanged();
            }

        }

        private Color _getColor;
        public Color GetColor
        {
            get { return _getColor; }
            set { _getColor= value;
                OnPropertyChanged();
            }
        }

        private double _sliderValue=1;
        public double SliderValue
        {
            get { return _sliderValue; }
            set {
                _sliderValue = value;
                OnPropertyChanged();
            }
        }
        public ICommand NextCommand { get;private set; }
        public event EventHandler NextCommandChanged;
        public void ValueChange()
        {
            
            if (SliderValue>=1 && SliderValue <= 10)
            {
                GetColor = Colors.PaleVioletRed;
                DisplayMood = "Hated it";
                GetImageSource = "angry.png";
            }
            else if(SliderValue>10 && SliderValue <= 20)
            {
                GetColor = Colors.LightCoral;
                DisplayMood = "Was Ok";
                GetImageSource = "angryok.png";
            }else 
            {
                GetColor = Colors.SkyBlue;
                DisplayMood = "Loved";
                GetImageSource = "loved.png";
            }   
        }
        public void NextValue()
        {
            NextCommandChanged?.Invoke(this, new EventArgs());
        }

        public FoodViewModel()
        {
            NextCommand = new Command(NextValue);
        }
    }
}
