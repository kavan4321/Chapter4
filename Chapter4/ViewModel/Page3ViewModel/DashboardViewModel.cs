using Chapter4.Model.Page3Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Chapter4.ViewModel.Page3ViewModel.NickNameCall
{
    public class DashboardViewModel :INotifyPropertyChanged
    {
        private RegistrationModel _registrationModel;

        public RegistrationModel RegistrationModelDetails
        {
            get
            {
                return _registrationModel;
            }
            set
            {
                _registrationModel = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
       
        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public DashboardViewModel()
        {

        }
    }
}
