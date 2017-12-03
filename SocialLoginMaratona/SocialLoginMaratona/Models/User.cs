using Newtonsoft.Json;

namespace SocialLoginMaratona.Models
{
    public class User
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }
    }
}
