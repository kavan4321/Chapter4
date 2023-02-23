using Chapter4.Model.Page4Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Chapter4.ViewModel.Page4ViewModel.CreateDetails
{
    public class CreateInvoiceViewModel : INotifyPropertyChanged
    {
        private readonly CreateInvoiceModel _createInvoiceModel;
       
        public event PropertyChangedEventHandler PropertyChanged;

        public string ProductName { get; set; }
        public string PurchaseDate { get; set; }
        public string PurchaseTime { get; set; }
        public bool IsPremium { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNumber { get; set; }
        public string Address { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
        public double Tax { get; set; }

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        public void PropertyCalling()
        {
            _createInvoiceModel.ProductName= ProductName;
            _createInvoiceModel.PurchaseDate= PurchaseDate;
            _createInvoiceModel.PurchaseTime = PurchaseTime;

        }

        public CreateInvoiceViewModel()
        {
            _createInvoiceModel= new CreateInvoiceModel();
            PropertyCalling();
        }

    }
}
