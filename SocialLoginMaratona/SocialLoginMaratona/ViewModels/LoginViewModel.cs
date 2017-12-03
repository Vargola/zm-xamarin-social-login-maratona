using SocialLoginMaratona.Helpers;
using SocialLoginMaratona.Services;
using SocialLoginMaratona.Views;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SocialLoginMaratona.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        AzureService azureService;

        ICommand loginCommand;

        public ICommand LoginCommand => loginCommand ?? (loginCommand = new Command(async () => await ExecuteLoginCommandAsync()));

        public LoginViewModel()
        {
            azureService = DependencyService.Get<AzureService>();
            Title = "Social Login Demo";
        }

        private async Task ExecuteLoginCommandAsync()
        {
            if (IsBusy || !(await LoginAsync()))
                return;
            else
            {
                await PushAsync<MainViewModel>();
            }
        }

        public Task<bool> LoginAsync()
        {
            if (Settings.IsLoggedIn)
                return Task.FromResult(true);
            return azureService.LoginAsync();
        }
    }
}
