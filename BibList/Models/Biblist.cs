namespace BibList.Models
{
    public class Biblist
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string PublishingHouse { get; set; }
        public string ReleaseDate { get; set; }
        public int InStock { get; set; }
    }
}
