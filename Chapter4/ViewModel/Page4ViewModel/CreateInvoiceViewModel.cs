using Chapter4.Model.Page4Model;
using CommunityToolkit.Maui.Alerts;
using Microsoft.Maui.Controls;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Windows.Input;

namespace Chapter4.ViewModel.Page4ViewModel.CreateDetails
{
    public class CreateInvoiceViewModel : INotifyPropertyChanged
    {
        private readonly CreateInvoiceModel _createInvoiceModel;
       
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        public ICommand GenerateCommand { get; private set; }
        public string ProductName { get; set; }
        public DateTime PurchaseDate { get; set; }
        public TimeSpan PurchaseTime { get; set; }
        public bool IsPremium { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNumber { get; set; }
        public string Address { get; set; }

        private double _quantity=1;
        public double Quantity
        {
            get { return _quantity; }
            set { 
                _quantity = value;
                 OnPropertyChanged();
            }

        }
     
        public bool Success { get; set; }
        public string Amount { get; set; }
        public string Tax { get; set; }

      


        public  void Validation()
        {
            if((string.IsNullOrEmpty(ProductName) && string.IsNullOrWhiteSpace(ProductName)) &&
               (string.IsNullOrEmpty(CustomerName) && string.IsNullOrWhiteSpace(CustomerName)) &&
               (string.IsNullOrEmpty(CustomerNumber) && string.IsNullOrWhiteSpace(CustomerNumber)) &&
               (string.IsNullOrEmpty(Address) && string.IsNullOrWhiteSpace(Address)) &&
               (string.IsNullOrEmpty(Amount) && string.IsNullOrWhiteSpace(Amount)) &&
               (string.IsNullOrEmpty(Tax) && string.IsNullOrWhiteSpace(Tax))
               )
            {
                Toast.Make("Please Enter Values", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if((string.IsNullOrEmpty(ProductName) && string.IsNullOrWhiteSpace(ProductName)))
            {
                Toast.Make("Please Enter Product Name", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if ((string.IsNullOrEmpty(CustomerName) && string.IsNullOrWhiteSpace(CustomerName)))
            {
                Toast.Make("Please Enter Customer Name", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if ((string.IsNullOrEmpty(CustomerNumber) && string.IsNullOrWhiteSpace(CustomerNumber)))
            {
                Toast.Make("Please Enter Phone Number", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if (CustomerNumber.Length<10)
            {
                Toast.Make("Please Enter Phone Number Correctly", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if ((string.IsNullOrEmpty(Address) && string.IsNullOrWhiteSpace(Address)))
            {
                Toast.Make("Please Enter Address", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if ((string.IsNullOrEmpty(Amount) && string.IsNullOrWhiteSpace(Amount)))
            {
                Toast.Make("Please Enter Amount", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if ((string.IsNullOrEmpty(Tax) && string.IsNullOrWhiteSpace(Tax)))
            {
                Toast.Make("Please Enter Tax Amount", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else
            {
                Success = true;             
            }
        }
        public void PropertyCalling()
        {
            _createInvoiceModel.ProductName = ProductName;
            _createInvoiceModel.PurchaseDate = PurchaseDate.ToString("dd-MMM-yyyy");
            _createInvoiceModel.PurchaseTime = PurchaseTime.ToString();
            _createInvoiceModel.IsPremium = IsPremium;
            _createInvoiceModel.CustomerName = CustomerName;
            _createInvoiceModel.CustomerNumber = CustomerNumber;
            _createInvoiceModel.Address = Address;
            _createInvoiceModel.Amount = Amount;
            _createInvoiceModel.Tax = Tax;
        }

        public void Methods()
        {
            Validation();
            PropertyCalling();
        }

        public CreateInvoiceViewModel()
        {
            _createInvoiceModel= new CreateInvoiceModel();
            GenerateCommand = new Command(PropertyCalling);
        }

    }
}
