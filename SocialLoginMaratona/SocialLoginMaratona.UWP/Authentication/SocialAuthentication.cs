using Microsoft.WindowsAzure.MobileServices;
using SocialLoginMaratona.UWP;
using System.Collections.Generic;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(SocialAuthentication))]
namespace SocialLoginMaratona.UWP
{
    public class SocialAuthentication : IAuthentication
    {
        public async Task<MobileServiceUser> LoginAsync(
            MobileServiceClient client,
            MobileServiceAuthenticationProvider provider,
            IDictionary<string,string> parameters = null)
        {
            try
            {
                var user = await client.LoginAsync(provider);
                return user;
            }
            catch
            {
                throw;
            }
        }

    }
}
