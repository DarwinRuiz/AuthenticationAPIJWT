using AuthenticationAPIJWT.Models;

namespace AuthenticationAPIJWT.Dtos.Auth
{
    public class SignInResponse
    {
        public string token {  get; set; }
        public User user { get; set; }

        public SignInResponse(string token, User user)
        {
            this.token = token;
            this.user = user;
        }
    }
}
