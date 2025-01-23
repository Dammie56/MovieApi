namespace MovieBlogAPI.Dto
{
    public class GetMovieDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int ReleaseDate { get; set; }
        public double Rating { get; set; }
    }
}
