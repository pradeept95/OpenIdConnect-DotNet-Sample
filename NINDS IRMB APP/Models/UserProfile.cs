using Newtonsoft.Json;

namespace NINDS_IRMB_APP.Models
{
    public class UserProfile
    {
        [JsonProperty("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")]
        public string UserId { get; set; }

        [JsonProperty("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname")]
        public string FirstName { get; set; }

        [JsonProperty("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname")]
        public string LastName { get; set; }
        
        [JsonProperty("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress")]
        public string Email { get; set; }
        
        [JsonProperty("email_verified")]
        public bool IsEmailVerified { get; set; }

        [JsonProperty("name")]
        public string DisplayName { get; set; }

        [JsonProperty("nickname")]
        public string NickName { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("picture")]
        public string ProfilePic { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }  
}
