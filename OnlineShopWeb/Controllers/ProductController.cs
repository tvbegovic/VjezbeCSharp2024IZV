using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace OnlineShopWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IConfiguration configuration;

        public ProductController(IConfiguration configuration) 
        {
            this.configuration = configuration;
        }

        [HttpGet("")]
        public List<Product> GetProducts()
        {
            string sql = "SELECT * FROM Product";
            using (var connection = new SqlConnection(configuration.GetConnectionString("connString")))
            {
                return connection.Query<Product>(sql).ToList();
            }
        }

        [HttpGet("{id}")]
        public Product GetProduct(int id)
        {
            string sql = "SELECT * FROM Product WHERE id = @id";
            using (var connection = new SqlConnection(configuration.GetConnectionString("connString")))
            {
                return connection.QueryFirstOrDefault<Product>(sql, new {  id });
            }
        }
    }
}
