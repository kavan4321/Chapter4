
namespace Chapter4.Model.Page5Model
{
    public class LoginScreenModel
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public string EmailId
        {
            get => "admin@gmail.com";
            set { }
        }
        public string PasswordInfo
        {
            get => "Admin#123";
            set { }
        }
    }
}
