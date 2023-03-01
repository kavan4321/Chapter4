using CommunityToolkit.Maui.Alerts;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Chapter4.ViewModel.Page6ViewModel.Gpays
{
    public class GpayViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Name { get; set; }
        public string Amount { get; set; }

        private string _displayName;
        public string DisplayName
        {
            get { return _displayName; }
            set
            {
                _displayName = value;
                OnPropertyChanged();
            }
        }

        private string _displayAmount;
        public string DisplayAmount
        {
            get { return _displayAmount; }
            set
            {
                _displayAmount = value;
                OnPropertyChanged();
            }
        }
        public ICommand PayCommand { get;private set; }
        public event EventHandler PayCommandChanged;

        public void DisplayValue()
        {
            DisplayName = Name;
            DisplayAmount= Amount;
        }
        public void Validation()
        {
            if( (string.IsNullOrEmpty(Name) || string.IsNullOrWhiteSpace(Name)) &&
                 (string.IsNullOrEmpty(Amount) || string.IsNullOrWhiteSpace(Amount))
                ) 
            {
                Toast.Make("Plese Enter Value", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if((string.IsNullOrEmpty(Name) || string.IsNullOrWhiteSpace(Name)))
            {
                Toast.Make("Plese Enter Name", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if((string.IsNullOrEmpty(Amount) || string.IsNullOrWhiteSpace(Amount)))
            {
                Toast.Make("Plese Enter Amount", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else
            {
                PayCommandChanged?.Invoke(this, new EventArgs());
            }
        }


        public GpayViewModel()
        {
            PayCommand = new Command(Validation);
        }
    }
}
