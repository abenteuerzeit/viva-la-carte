namespace MvcVivaLaCarte.Models
{
    public class LoginViewModel
    {

        public string LoginProvider { get; set; }
        public string ReturnUrl { get; set; }

        public bool RememberMe { get; set; }

        public int ReturnCode { get; set; }

        public DateTime ReturnDate { get; set; }

        public LoginViewModel(string loginProvider, string returnUrl, bool rememberMe, int returnCode)
        {
            LoginProvider = loginProvider;
            ReturnUrl = returnUrl;
            RememberMe = rememberMe;
            ReturnDate = DateTime.Now;
            ReturnCode = returnCode;
        }
    }
}
