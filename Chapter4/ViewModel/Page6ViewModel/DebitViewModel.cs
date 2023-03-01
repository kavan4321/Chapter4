
using CommunityToolkit.Maui.Alerts;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Input;

namespace Chapter4.ViewModel.Page6ViewModel.Debits
{
    public class DebitViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public ICommand PayCommand { get;private set; }
        public event EventHandler PayCompleted;
        public string Name { get; set; }
        public string Account { get; set; }
        public string Amount { get; set; }
        public string CVV { get; set; }

        private DateTime _accountDate;
        public DateTime AccountDate 
        {
            get { return _accountDate; }
            set { _accountDate = value;
                OnPropertyChanged();
            }
        }

        private string _displayName;
        public string DisplayName
        {
            get { return _displayName; }
            set { _displayName = value;
                OnPropertyChanged();
            }
        }
       
        private string _displayAccount;
        public string DisplayAccount
        {
            get { return _displayAccount; }
            set
            {
                _displayAccount = value;
                OnPropertyChanged();
            }
        }

         private string _displayDate;
        public string DisplayDate
        {
            get { return _displayDate; }
            set
            {
                _displayDate = value;
                OnPropertyChanged();
            }
        }

        public void DisplayValue()
        {
            DisplayName = Name;
            DisplayAccount= Account;
        }
        public void Display()
        {
            DisplayDate = AccountDate.ToString("d/M/yyyy");
        }
        public void Validation()
        {
            if(  (string.IsNullOrEmpty(Name) || string.IsNullOrWhiteSpace(Name)) &&
                 (string.IsNullOrEmpty(Account) || string.IsNullOrWhiteSpace(Account)) &&
                 (string.IsNullOrEmpty(Amount) || string.IsNullOrWhiteSpace(Amount)) &&
                 (string.IsNullOrEmpty(CVV) || string.IsNullOrWhiteSpace(CVV))               
                )
            {
                Toast.Make("Please Enter Value", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if((string.IsNullOrEmpty(Name) || string.IsNullOrWhiteSpace(Name)))
            {
                Toast.Make("Please Enter Name", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if((string.IsNullOrEmpty(Account) || string.IsNullOrWhiteSpace(Account)))
            {
                Toast.Make("Please Enter Account Number", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if (Account.Length < 12)
            {
                Toast.Make("Account Nuumber Should be 12 digit", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if((string.IsNullOrEmpty(Amount) || string.IsNullOrWhiteSpace(Amount)))
            {
                Toast.Make("Please Enter Amount", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if((string.IsNullOrEmpty(CVV) || string.IsNullOrWhiteSpace(CVV)))
            {
                Toast.Make("Please Enter CVV", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if (CVV.Length < 3)
            {
                Toast.Make("CVV Nuumber Should be 3 digit", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else
            {
                PayCompleted?.Invoke(this, new EventArgs());
            }
        }
        public DebitViewModel()
        {
            PayCommand = new Command(Validation);
        }
    }

}
