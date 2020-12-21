using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using LoginCred.Domain.Interfaces;
using LoginCred.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace LoginCred.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class UserController : Controller
    {
        readonly IConfiguration Config;
        readonly IUserServices service;
        public UserController(IConfiguration config, IUserServices service)
        {
            this.service = service;
            this.Config = config;
        }
        [HttpPost("login")]
        public IActionResult Login([FromBody] Credentials model)
        {
            ValidationResponse result = new ValidationResponse();

            if (service.login(model)=="admin")
            {
                result.UserType = "admin";
                result.Jwt = GenerateToken("admin", model.UserName);
            }
            else if (service.login(model) == "customer")
            {
                result.UserType = "customer";
                result.Jwt = GenerateToken("customer", model.UserName);
            }
            else
            {
                return BadRequest("Invalid username/password");
            }
            result.UserName = model.UserName;

            return Ok(result);
        }

        private string GenerateToken(string userType, string username)
        {
            string token = string.Empty;

            var now = DateTime.Now;

            var claims = new Claim[] {
            new Claim(JwtRegisteredClaimNames.Sub, username),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(JwtRegisteredClaimNames.Iat, now.ToUniversalTime().ToString()),
            new Claim("UserType", userType)
            };

            var KeyText = Config.GetValue<string>("SecurityKey");
            var KeyBytes = Encoding.ASCII.GetBytes(KeyText);
            var Key = new SymmetricSecurityKey(KeyBytes);

            var Jwt = new JwtSecurityToken(claims: claims,
                                           expires: now.AddMinutes(60),
                                           signingCredentials: new SigningCredentials(Key, SecurityAlgorithms.HmacSha256));
            token = new JwtSecurityTokenHandler().WriteToken(Jwt);

            return token;

        }
        [HttpPost("register")]
        public IActionResult signup(User u)
        {
            var a=service.SignUP(u);
           
            return Ok();
        }
    }
}
    
