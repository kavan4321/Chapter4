
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Chapter4.ViewModel.Page6ViewModel.SelectMethod;

public class PaymentMethodViewModel :INotifyPropertyChanged
{
    private bool _creditCard=true;
    public bool CreditCard 
    { 
        get { return _creditCard; }
        set
        {
            _creditCard = value;
            OnPropertyChanged();
        }
    }
    public bool DebitCard { get; set; }
    public bool Gpay { get; set; }
    
    public event EventHandler CreditCardChanged;
   
    public event EventHandler DebitCardChanged;
   
    public event EventHandler GpayChanged;

    public ICommand NextCommand { get;private set; }

    public void SelectMethod()
    {
        if (CreditCard == true)
        {
            CreditCardChanged?.Invoke(this, new EventArgs());
        }
        else if(DebitCard== true)
        {
            DebitCardChanged?.Invoke(this, new EventArgs());
        }
        else
        {
            GpayChanged?.Invoke(this, new EventArgs());
        }
    }


    public PaymentMethodViewModel()
    {
        NextCommand = new Command(SelectMethod);
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public void OnPropertyChanged([CallerMemberName] string name = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
