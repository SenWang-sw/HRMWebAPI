using JWTAuthManager.Model;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using JwtRegisteredClaimNames = System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames;

namespace JWTAuthManager
{
    public class JwtTokenHandler
    {
        public const string JWT_Secret_Key = "u8x/A?D(G+KbPeSgVkYp3s6v9y$B&E)H@McQfTjWmZq4t7w!z%C*F-JaNdRgUkXp";
        private const int JWT_Token_Validity_Mins = 20;
       // private readonly List<UserAccount> userAccounts;
        public JwtTokenHandler()
        {
            /*
            userAccounts = new List<UserAccount>()
            {
                new UserAccount()
                {
                    UserName = "admin",
                    Password = "admin@1234",
                    Role = "Admin"
                },
                new UserAccount()
                {
                    UserName = "client",
                    Password = "client@1234",
                    Role = "Client"
                },
                new UserAccount()
                {
                    UserName = "user",
                    Password = "user@1234",
                    Role = "User"
                }
            };
            */
        }
        public AuthenResponse GenerateToken(AuthenRequest request,string role)
        {
            /*
            if(string.IsNullOrEmpty(request.UserName)||string.IsNullOrEmpty(request.Password))
            {
                return null;
            }
            var res = userAccounts.Where(x=>x.UserName == request.UserName&&x.Password==request.Password).FirstOrDefault();
            if(res == null)
            {
                return null;
            }
            */
            // not null => jwt
            var tokenExpireTime = DateTime.UtcNow.AddMinutes(JWT_Token_Validity_Mins);
            var tokenKey = Encoding.ASCII.GetBytes(JWT_Secret_Key);
            var claimsIdentity = new ClaimsIdentity(new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Name,request.UserName),
                new Claim(ClaimTypes.Role,role)
            });
            var signingCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey),
                    SecurityAlgorithms.HmacSha256Signature
                );
            var securityTokenDescripter = new SecurityTokenDescriptor {
                Subject = claimsIdentity,
                Expires = tokenExpireTime,
                SigningCredentials = signingCredentials
            };
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var securityToken = jwtSecurityTokenHandler.CreateToken(securityTokenDescripter);
            var token = jwtSecurityTokenHandler.WriteToken(securityToken);
            return new AuthenResponse
            {
                Token = token,
                ExpireIn = (int)tokenExpireTime.Subtract(DateTime.Now).TotalSeconds,
                UserName = request.UserName
            };
        }
    }
}