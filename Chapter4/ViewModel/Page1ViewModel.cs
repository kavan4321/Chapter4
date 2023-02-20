
using Chapter4.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;

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

        public string Name { get; set; }
        public string FromStation { get; set; }
        public string ToStation { get; set; }
        public string DepartureDate { get; set; }
        public string ReturnDate { get; set; }
        public string TrainDate { get; set; }
        public string TrainTime { get; set; }




        public void MethodCalling()
        {
           Name=_page1Model.Name;
        }
        public Page1ViewModel()
        {
            _page1Model = new Page1Model();
            MethodCalling();
        }
        
    }
}
