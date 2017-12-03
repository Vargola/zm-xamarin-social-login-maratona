using SocialLoginMaratona.Helpers;

namespace SocialLoginMaratona.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public string UserId { get; }
        public string Token { get; }

        public MainViewModel()
        {
            UserId = Settings.UserId;
            Token = Settings.AuthToken;
        }
    }
}
