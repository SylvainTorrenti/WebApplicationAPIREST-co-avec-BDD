namespace WebApplicationAPIREST
{
    public class Personne
    {
        public string nom { get; set; }
        public string prenom { get; set; }

        public Personne(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }
    }
}
