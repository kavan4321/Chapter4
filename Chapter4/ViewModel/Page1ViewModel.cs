
using Chapter4.Model;
using CommunityToolkit.Maui.Alerts;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Chapter4.ViewModel.Train
{
    public class Page1ViewModel: INotifyPropertyChanged
    {
        private readonly Page1Model _page1Model;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public ICommand SwapCommand { get;private set; }
        public ICommand SearchCommmand { get;private set; }
      
        public string Name { get; set; }

        private string _fromStation;
        public string FromStation
        {
            get { return _fromStation; }
            set
            {
                _fromStation= value;
                OnPropertyChanged();
            }
        }

        private string _toStation;
        public string ToStation
        {
            get { return _toStation; }
            set
            {
                _toStation = value;
                OnPropertyChanged();
            }
        }

        public string DepartureDate { get; set; }
        public string ReturnDate { get; set; }
        public string TrainDate { get; set; }
        public string TrainTime { get; set; }


        private bool _isVisible;
        public bool IsVisible
        {
            get { return _isVisible; } 
            set
            { 
                _isVisible= value;
                OnPropertyChanged();
            }
        }

        private string _upcomingfromStation;
        public string UpcomingFromStation
        {
            get { return _upcomingfromStation; }
            set
            {
                _upcomingfromStation = value;
                OnPropertyChanged();
            }
        }

        private string _upcomingtoStation;
        public string UpcomingToStation
        {
            get { return _upcomingtoStation; }
            set
            {
                _upcomingtoStation = value;
                OnPropertyChanged();
            }
        }



        


        public void Swaping()
        {
            var temp = FromStation;
            FromStation=ToStation;
            ToStation=temp;
        }

        public void SearchTrain()
        {

            IsVisible = true;
            if ((string.IsNullOrEmpty(FromStation) || (string.IsNullOrWhiteSpace(FromStation))) &&
                (string.IsNullOrEmpty(ToStation) || (string.IsNullOrWhiteSpace(ToStation))) &&
                (string.IsNullOrEmpty(DepartureDate) || (string.IsNullOrWhiteSpace(DepartureDate))) &&
                (string.IsNullOrEmpty(ReturnDate) || (string.IsNullOrWhiteSpace(ReturnDate)))
                )
            {
                Toast.Make("Please Enter Value & Date", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if (string.IsNullOrEmpty(FromStation) || (string.IsNullOrWhiteSpace(FromStation)))
            {
                Toast.Make("Please Enter From Station value", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if (string.IsNullOrEmpty(ToStation) || (string.IsNullOrWhiteSpace(ToStation)))
            {
                Toast.Make("Please Enter To Station value", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if (string.IsNullOrEmpty(DepartureDate) || (string.IsNullOrWhiteSpace(DepartureDate)))
            {
                Toast.Make("Please Select Departure Date", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if (string.IsNullOrEmpty(ReturnDate) || (string.IsNullOrWhiteSpace(ReturnDate)))
            {
                Toast.Make("Please Select Return Date", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else
            {              
                UpcomingFromStation = FromStation;
                UpcomingToStation = ToStation;
            }    
        }



        public void MethodCalling()
        {
           Name=_page1Model.Name;
        }
        public Page1ViewModel()
        {
            _page1Model = new Page1Model();
            MethodCalling();
            SwapCommand=new Command(Swaping);
            SearchCommmand = new Command(SearchTrain);
        }
        
    }
}
