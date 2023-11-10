using Microsoft.AspNetCore.Mvc;

namespace WebApplicationAPIREST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonneController : ControllerBase
    {

        private readonly ILogger<PersonneController> _logger;

        public PersonneController(ILogger<PersonneController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPersonne")]
        public IEnumerable<Personne> Get()
        {
            Personne p1 = new Personne("FOURRE", "Julien");
            Personne p2 = new Personne("TORRENTI", "Sylvain");
            Personne p3 = new Personne("Sabadie", "Jeremy");

            List<Personne> listPersonne = new List<Personne> { p1, p2, p3 };

            _logger.LogInformation("Retourne " + listPersonne.Count + " éléments");

            return listPersonne;
        }

    }
}