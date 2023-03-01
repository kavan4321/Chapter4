
using Chapter4.Model;
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

        
        public void Swaping()
        {
            var temp = FromStation;
            FromStation=ToStation;
            ToStation=temp;
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
        }
        
    }
}
