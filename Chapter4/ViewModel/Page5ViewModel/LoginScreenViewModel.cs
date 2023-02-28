
using Chapter4.Model.Page5Model;
using CommunityToolkit.Maui.Alerts;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Chapter4.ViewModel.Page5ViewModel.LoginSign
{
    public class LoginScreenViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string Name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));
        }

        private readonly LoginScreenModel _loginScreenModel;  
        public ICommand SignInCommand { get;private set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public event EventHandler SignInEvent;


        public void Validation()
        {
       
            if (((string.IsNullOrEmpty(Email)) || (string.IsNullOrWhiteSpace(Email))) &&
                ((string.IsNullOrEmpty(Password)) || (string.IsNullOrWhiteSpace(Password)))
                ) 
            {
                Toast.Make("Please Enter Email and Password",CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if( (string.IsNullOrEmpty(Email)) || (string.IsNullOrWhiteSpace(Email))  )
            {
                Toast.Make("Please Enter Email", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if( (string.IsNullOrEmpty(Password)) || (string.IsNullOrWhiteSpace(Password)) )
            {
                Toast.Make("Please Enter Password", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if (!Email.Contains('@') || (!Email.Contains('.')))
            {
                Toast.Make("Enter Valid Email", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if (Password.Length < 8)
            {
                Toast.Make("Enter Password is to small", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if (Email != _loginScreenModel.EmailId && Password!=_loginScreenModel.PasswordInfo)
            {
                Toast.Make("Enter Email & Password is not match", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if(Email != _loginScreenModel.EmailId)
            {
                Toast.Make("Enter Email is not match", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if (Password != _loginScreenModel.PasswordInfo)
            {
                Toast.Make("Enter Password is not match", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else
            {
                SignInEvent?.Invoke(this,new EventArgs());
            }
        }
        public LoginScreenViewModel()
        { 
            _loginScreenModel = new LoginScreenModel();
            SignInCommand = new Command(Validation);
        }
    }
}
