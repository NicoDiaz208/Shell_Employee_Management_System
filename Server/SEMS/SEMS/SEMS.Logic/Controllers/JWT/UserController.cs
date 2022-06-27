using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SEMS.Logic.Entities.JWT;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SEMS.Logic.Controllers.JWT
{
    public class UserController : GenericController<User>, IJWTManagerController
    {
        private readonly IConfiguration _configuration;

        public UserController(IConfiguration configuration) : base()
        {
            this._configuration = configuration;
        }

        public UserController(IConfiguration configuration, ControllerObject other) : base(other)
        {
            this._configuration = configuration;
        }

        public async Task<Tokens?> Authenticate(String username, String password)
        {

            //var checkEntity = await _userController.GetUserByUsernameAndPasswordAsync(users.Username, users.Password);
            var checkEntity = await EntitySet.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == password).FirstOrDefaultAsync();
            if (checkEntity == null)
            {
                return null;
            }
            
            // Else we generate JSON Web Token
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes(_configuration["User:JWTKey"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
              {
             new Claim(ClaimTypes.Name, username)
              }),
                Expires = DateTime.UtcNow.AddMinutes(10),           //JWT espires every 10 Mins after created
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return new Tokens { Token = tokenHandler.WriteToken(token) };

        }

        public Task<User?> GetUserByUsernameAndPasswordAsync(string username, string password)
        {
            return EntitySet.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == password).FirstOrDefaultAsync();
        }
    }
}
