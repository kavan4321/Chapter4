
using Chapter4.Model.Page6Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace Chapter4.ViewModel.Page6ViewModel.Confirms
{

    public class ConfirmViewModel : INotifyPropertyChanged
    {
        private  CreditModel _creditModelDetails;
        public CreditModel CreditModelDetails
        {
            get { return _creditModelDetails; }
            set {
                _creditModelDetails = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
       
    }
}
