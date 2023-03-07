
using Chapter4.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Chapter4.ViewModel.Turcks
{
    public class Page2ViewModel : INotifyPropertyChanged
    {

        private readonly Page2Model _page2Model;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public ICommand MinusCommand { get; private set; }
        public ICommand FirstCommand { get;private set; }
        public ICommand SecondCommand { get; private set; }
        public ICommand ThirdCommand { get; private set; }

        public ICommand FirstTurckCommand { get; private set; }
        public ICommand  SecondTurckCommand { get; private set; }


        public string Name { get; set; }
        public string TruckWidth { get; set; }
        public string TruckWeight { get; set; }
        public DateTime SelcetDate { get; set; }
        public DateTime SelcetTime { get; set; }

        public int _amount;
        public int Amount 
        {
            get 
            { 
                return _amount;
            } 
            set
            {
                _amount = value;
                OnPropertyChanged();
            }
        }


        public void ChangeValue()
        {
           
        }


        public void PropertyCalling()
        {
            Name = _page2Model.Name;
            TruckWidth= _page2Model.TruckWidth;
            TruckWeight= _page2Model.TruckWeight;
        }
        
        public Page2ViewModel() 
        {
            _page2Model = new Page2Model();
            PropertyCalling();
        }

    }
}
