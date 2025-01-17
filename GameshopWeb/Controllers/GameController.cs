using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace GameshopWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IConfiguration configuration;

        public GameController(IConfiguration configuration) 
        {
            this.configuration = configuration;
        }

        [HttpGet("genres")]
        public List<Genre> GetGenres()
        {
            using(var connection = new SqlConnection(configuration.GetConnectionString("connString")))
            {
                return connection.Query<Genre>("SELECT * FROM Genre").ToList();
            }
        }

        [HttpGet("companies")]
        public List<Company> GetCompanies()
        {
            using (var connection = new SqlConnection(configuration.GetConnectionString("connString")))
            {
                return connection.Query<Company>("SELECT * FROM Company").ToList();
            }
        }

        [HttpGet("bygenre/{id}")]
        public List<Game> GetByGenre(int id)
        {
            using (var connection = new SqlConnection(configuration.GetConnectionString("connString")))
            {
                return connection.Query<Game>("SELECT * FROM Game WHERE idGenre = @id", new { id }).ToList();
            }
        }

        [HttpGet("bycompany/{id}")]
        public List<Game> GetByCompany(int id)
        {
            using (var connection = new SqlConnection(configuration.GetConnectionString("connString")))
            {
                return connection.Query<Game>("SELECT * FROM Game WHERE idDeveloper = @id OR idPublisher = @id", new { id }).ToList();
            }
        }

        [HttpGet("filterByPrices")]
        public List<Game> FilterByPrices(double? from, double? to)
        {
            using (var connection = new SqlConnection(configuration.GetConnectionString("connString")))
            {
                string sql = 
                 @"SELECT * FROM Game
                WHERE 
                (price >= @from OR @from IS NULL) AND
                (price <= @to OR @to IS NULL)";
                return connection.Query<Game>(sql, new { from, to }).ToList();
            }
        }

        [HttpGet("search/{text}")]
        public List<Game> Search(string text)
        {
            string textParam = $"%{text}%";
            using (var connection = new SqlConnection(configuration.GetConnectionString("connString")))
            {
                return connection.Query<Game>("SELECT * FROM Game WHERE Title LIKE @textParam", new { textParam }).ToList();
            }
        }
    }
}
