using MovieBlogAPI.Dto;
using MovieBlogAPI.Models;

namespace MovieBlogAPI.Interfaces
{
    public interface IMovieRepository
    {
        ICollection<Movie> GetMovies();
        Movie GetMovieById(int id);
        Movie GetMovieByTitle(string title);
        Movie GetMovieTrimToUpper(MovieDto movieCreate);
        decimal GetMovieRating(int movieId);
        bool MovieExists(int movieId);
        bool CreateMovie(Movie movie);
        bool UpdateMovie(int Id, Movie movie);
        bool DeleteMovie(Movie movie);
        bool Save();

    }
}
