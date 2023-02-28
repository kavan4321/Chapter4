
using CommunityToolkit.Maui.Alerts;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Chapter4.ViewModel.Page6ViewModel.Credits
{
    public class CreditViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
        }

        public event EventHandler PayEvent;
        public Command PayCommand { get;private set; }
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


        public void DisplayText()
        {
            DisplayName= Name;
            DisplayAmount = Amount;
        }

        public void Validation()
        {
            if((string.IsNullOrEmpty(Name) || string.IsNullOrWhiteSpace(Name)) &&
                (string.IsNullOrEmpty(Amount) || string.IsNullOrWhiteSpace(Amount))
               )
            {
                Toast.Make("Please Enter Name and Amount", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if (string.IsNullOrEmpty(Name) || string.IsNullOrWhiteSpace(Name))
            {
                Toast.Make("Please Enter Name", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if (string.IsNullOrEmpty(Amount) || string.IsNullOrWhiteSpace(Amount))
            {
                Toast.Make("Please Enter Amount", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else
            {
                PayEvent?.Invoke(this, new EventArgs());
            }
        }


        public CreditViewModel()
        {
            PayCommand = new Command(Validation);
        }
    }
}
