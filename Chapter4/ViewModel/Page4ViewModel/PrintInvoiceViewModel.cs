using Chapter4.Model.Page4Model;
using Chapter4.ViewModel.Page4ViewModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Chapter4.ViewModel.Page4ViewModel.PrintDetails
{
    public class PrintInvoiceViewModel : INotifyPropertyChanged
    {
        private CreateInvoiceModel _createInvoiceModel;

  
        public CreateInvoiceModel CreateInvoiceDetails
        {
            get { return _createInvoiceModel; }
            set
            {
                _createInvoiceModel = value;
                OnPropertyChanged();
            }

        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string Name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));
        }
        public PrintInvoiceViewModel()
        {
            
        }
    }
}
