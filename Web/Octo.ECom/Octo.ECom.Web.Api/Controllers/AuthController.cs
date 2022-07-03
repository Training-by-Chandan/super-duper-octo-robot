using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Text;
using Octo.ECom.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace Octo.ECom.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IConfiguration _configuration;
        private readonly ApplicationDbContext db;

        public AuthController(
            IConfiguration configuration,
            ApplicationDbContext db
            )
        {
            this._configuration = configuration;
            this.db = db;
        }

        [HttpPost("get-token")]
        public async Task<IActionResult> GetToken(string username, string password)
        {
            var user = db.Users.FirstOrDefault(p => p.UserName == username);
            if (user != null)
            {
                var hasher = new PasswordHasher<IdentityUser>();
                var hashed = hasher.HashPassword(user, password);
                //if (hashed == user.PasswordHash)
                //{
                var claims = new[] {
                    new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat,DateTime.UtcNow.ToString()),
                    new Claim("UserId",user.Id),
                    new Claim("Username",user.UserName)
                    };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                var signin = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                    _configuration["Jwt:Issuer"],
                    _configuration["Jwt:Audience"],
                    claims,
                    expires: DateTime.UtcNow.AddMinutes(5),
                    signingCredentials: signin
                    );
                return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                // }
            }
            return BadRequest("Invalid username/password");
        }
    }
}