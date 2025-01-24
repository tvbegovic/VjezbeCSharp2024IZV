using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace GameshopWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration configuration;

        public UserController(IConfiguration configuration)
        {
            this.configuration = configuration;
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
                return Ok(result);
            }
        }
    }

    public class LoginResult
    {
        public User User { get; set; }
        public string AccessToken { get; set; }
    }
}
