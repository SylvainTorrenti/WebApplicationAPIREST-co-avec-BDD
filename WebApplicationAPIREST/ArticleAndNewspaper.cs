namespace WebApplicationAPIREST
{
    public class ArticleAndNewspaper
    {
        public int IDArticle { get; set; }
        public int IDJournal { get; set; }
        public string TitreArticle { get; set; }
        public string? Auteur { get; set; }
        public string Titrejournal { get; set; }
        public DateTime? DtParution { get; set; }
    }
}
