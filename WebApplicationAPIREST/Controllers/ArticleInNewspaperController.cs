using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace WebApplicationAPIREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleInNewspaperController : ControllerBase
    {
        //List<ArticleAndNewspaper> _articles = new();
        private readonly MySqlConnection _dbconnection = new("server=lab007.2isa.org;port=33007;UID=root;PWD=7852lab007;database=Edito");

        private readonly ILogger<ArticleInNewspaperController> _logger;

        public ArticleInNewspaperController(ILogger<ArticleInNewspaperController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "ArticleAndNewspaper")]
        public IEnumerable<Article> GetArticleInNewspaper()
        {

            try
            {
                _dbconnection.Open();
                var q = "SELECT * from article a join composition c on a.IDArticle = c.IDArticle join journal j on j.IDJournal = c.IDJournal ";
                return _dbconnection.Query<Article>(q);
            }

            finally
            {
                _dbconnection.Close();
            }

        }
    }
}
