using MovieBlogAPI.Models;

namespace MovieBlogAPI.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();
        Review GetReview(int reviewId);
        ICollection<Review> GetReviewsOfAMovie(int movieId);
        bool ReviewExists(int reviewId);
        bool ReviewExists(int reviewerId, int movieId);
        bool CreateReview(Review review);
        bool UpdateReview(int id, Review review);
        bool DeleteReview(Review review);
        bool DeleteReviews(List<Review> reviews);
        bool Save();
    }
}
