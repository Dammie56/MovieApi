using AutoMapper;
using MovieBlogAPI.Data;
using MovieBlogAPI.Dto;
using MovieBlogAPI.Interfaces;
using MovieBlogAPI.Models;

namespace MovieBlogAPI.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieDbContext _context;
        private readonly IMapper _mapper;

        public MovieRepository(MovieDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public bool CreateMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            return Save();
        }

        public bool DeleteMovie(Movie movie)
        {
            _context.Movies.Remove(movie);
            return Save();
        }

        public Movie GetMovieById(int id)
        {
            return _context.Movies.Where(m => m.Id == id).FirstOrDefault();

        }

        public Movie GetMovieByTitle(string title)
        {
            return _context.Movies.Where(m => m.Title == title).FirstOrDefault();
        }

        public decimal GetMovieRating(int movieId)
        {
            var review = _context.Reviews.Where(m => m.Movie.Id == movieId);

            if (review.Count() <= 0)
                return 0;

            return ((decimal)review.Sum(r => r.Rating) / review.Count());
        }

        public ICollection<Movie> GetMovies()
        {
            return _context.Movies.OrderBy(m => m.Id).ToList();
        }

        public Movie GetMovieTrimToUpper(MovieDto movieCreate)
        {
            return _context.Movies
        .FirstOrDefault(m => m.Title.Trim().ToUpper() == movieCreate.Title.Trim().ToUpper());
        }


        public bool MovieExists(int movieId)
        {
            return _context.Movies.Any(m => m.Id == movieId);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool UpdateMovie(int Id, Movie movie)
        {
            movie.Id = Id;
            _context.Update(movie);
            return Save();
        }
    }
}
