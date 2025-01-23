using System.ComponentModel.DataAnnotations;

namespace MovieBlogAPI.Models
{
    public class Review
    {


        public int Id { get; set; }
        public string Content { get; set; }

        [Range(1, 10, ErrorMessage = "Rating must be between 1 and 10")]
        public int Rating { get; set; }
        public int MovieId { get; set; } //This is a  Foreign Key
        public Movie Movie { get; set; } // Navigation Property
        public int ReviewerId { get; set; } // This is also a Foreign Key
        public Reviewer Reviewer { get; set; } // Navigation Property


    }
}
