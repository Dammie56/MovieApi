using System.ComponentModel.DataAnnotations;

namespace MovieBlogAPI.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int ReleaseDate { get; set; }

        [Range(1, 10, ErrorMessage = "Rating must be between 1 and 10")]
        public double Rating { get; set; }

        public ICollection<Review> Reviews { get; set; }
    }
}
