using System.ComponentModel.DataAnnotations;

namespace MovieBlogAPI.Dto
{
    public class GetReviewDto
    {
        public int Id { get; set; }
        public string Content { get; set; }
        [Range(1, 10, ErrorMessage = "Rating must be between 1 and 10")]
        public int Rating { get; set; }
        public int MovieId { get; set; }
    }
}
