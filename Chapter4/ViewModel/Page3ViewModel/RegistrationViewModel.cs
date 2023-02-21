using Chapter4.Model.Page3Model;
using Chapter4.View.Page3Views;
using CommunityToolkit.Maui.Alerts;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Chapter4.ViewModel.Page3ViewModel.QuizRegistration
{
    public class RegistrationViewModel : INotifyPropertyChanged
    {
        private readonly RegistrationModel _registrationModel;    

        public event PropertyChangedEventHandler PropertyChanged;

        public string FullName { get; set; }
        public string NickName { get; set; }
   
        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void MethodCalling()
        {
            _registrationModel.FullName= FullName;
            _registrationModel.NickName= NickName;
        }

        public RegistrationViewModel()
        {   
            _registrationModel = new RegistrationModel(); 
            MethodCalling();
        }

    }
}
