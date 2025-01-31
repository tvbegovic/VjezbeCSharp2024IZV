using Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace GameshopWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration configuration;
        private readonly JWTTokenConfig _jwtTokenConfig;

        public UserController(IConfiguration configuration, JWTTokenConfig jWTTokenConfig)
        {
            this.configuration = configuration;
            _jwtTokenConfig = jWTTokenConfig;
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] User user)
        {
            if(user.Password.Length < 8)
            {
                return BadRequest("Lozinka mora imati najmanje 8 znakova");
            }
            using (var connection = new SqlConnection(configuration.GetConnectionString("connString")))
            {
                string sqlEmail = "SELECT COUNT(*) FROM [User] WHERE email = @email";
                int broj = connection.ExecuteScalar<int>(sqlEmail, new { email = user.Email });
                if (broj > 0)
                {
                    return BadRequest("Već postoji korisnik s tom e-mail adresom");
                }
                string insertSql = @"INSERT INTO [User](
                firstname,lastname,address,email,password,admin,City
                ) OUTPUT inserted.id VALUES(
                @firstname,@lastname,@address,@email,@password,@admin,@City
                )";
                connection.Execute(insertSql, user);
                return Ok();
            }
        }

        [HttpGet("login")]
        public IActionResult Login(string email, string password)
        {
            using (var connection = new SqlConnection(configuration.GetConnectionString("connString")))
            {
                string sql = "SELECT * FROM [User] WHERE email = @email AND password = @password";
                User? user = connection.QueryFirstOrDefault<User>(sql, new { email, password });
                if (user == null)
                {
                    return BadRequest("Ne postoji korisnik s tim emailom ili lozinkom");
                }
                LoginResult result = new LoginResult();
                result.User = user;
                result.User.Password = null;
                result.AccessToken = GenerateToken(email, "user");
                return Ok(result);
            }
        }
        private string GenerateToken(string email, string role)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var keyBytes = Encoding.UTF8.GetBytes(_jwtTokenConfig.Secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
            new Claim(ClaimTypes.Name, email),
            new Claim(ClaimTypes.Role, role)
        }),
                Expires = DateTime.UtcNow.AddMinutes(_jwtTokenConfig.AccessTokenExpiration),
                Issuer = _jwtTokenConfig.Issuer,
                Audience = _jwtTokenConfig.Audience,
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(keyBytes),
                    SecurityAlgorithms.HmacSha256Signature
                )
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        [HttpPut("")]
        [Authorize]
        public void UpdateUser(User user)
        {
            string sql = @"UPDATE User SET  firstname=@firstname,lastname=@lastname,address=@address,City=@City
            WHERE id = @id";
            using (var connection = new SqlConnection(configuration.GetConnectionString("connString")))
            {
                connection.Execute(sql, user);
            }
        }
    }

    public class LoginResult
    {
        public User User { get; set; }
        public string AccessToken { get; set; }
    }
}
