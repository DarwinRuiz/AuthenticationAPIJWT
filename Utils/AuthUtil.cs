using AuthenticationAPIJWT.Data;
using AuthenticationAPIJWT.Models;
using IdentityModel;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AuthenticationAPIJWT.Utils
{
    public class AuthUtil
    {

        private readonly IConfiguration _configuration;

        public AuthUtil(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public User Authenticate(LoginUser loginUser)
        {
            User currentUser = DBContext.Users.FirstOrDefault(user => user.Username.ToLower().Equals(loginUser.UserName.ToLower())
            && user.Password.Equals(loginUser.Password)
            );

            return currentUser;
        }



        public string GenerateJWT(User user)
        {
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this._configuration["JWT:Key"]));
            SigningCredentials credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            Claim[] claims = new[]
            {
                new Claim(JwtClaimTypes.Subject, user.Username),
                new Claim(JwtClaimTypes.Email, user.EmailAddress),
                new Claim(JwtClaimTypes.Name, user.FirstName),
                new Claim(JwtClaimTypes.FamilyName, user.LastName),
                new Claim(JwtClaimTypes.Role, user.Rol)
            };

            JwtSecurityToken tokenConfiguration = new JwtSecurityToken(
                this._configuration["JWT:Issuer"],
                this._configuration["JWT:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(Double.Parse(this._configuration["JWT:TokenExpirationTimeInMinutes"])),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(tokenConfiguration);
        }
    }
}
