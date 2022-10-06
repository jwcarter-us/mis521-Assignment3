namespace mis521_Assignment3.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int year { get; set; }
        public byte[]? Poster { get; set; }

    }
}
