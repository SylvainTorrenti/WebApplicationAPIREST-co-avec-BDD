using Dapper;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace WebApplicationAPIREST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArticleController : ControllerBase
    {
        List<Article> _articles = new();
        private readonly MySqlConnection _dbconnection = new("server=lab007.2isa.org;port=33007;UID=root;PWD=7852lab007;database=Edito");

        private readonly ILogger<ArticleController> _logger;

        public ArticleController(ILogger<ArticleController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetArticle")]
        public IEnumerable<Article> Get()
        {
            try
            {
                _dbconnection.Open();
                var q = "SELECT * from article";
                return _dbconnection.Query<Article>(q);
            }

            finally
            {
                _dbconnection.Close();
            }
        }

    }
}