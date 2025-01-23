using Microsoft.EntityFrameworkCore;
using MovieBlogAPI.Models;

namespace MovieBlogAPI.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options)
            : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Everybody Loves Jenifa", Genre = "Comedy", ReleaseDate = 2024, Rating = 8.8 },
                new Movie { Id = 2, Title = "Alakada Bad and Boujee", Genre = "Comedy and Action", ReleaseDate = 2024, Rating = 7 },
                new Movie { Id = 3, Title = "Mufasa", Genre = "Action and Animation", ReleaseDate = 2024, Rating = 9.5 },
                new Movie { Id = 4, Title = "Seven Doors", Genre = "Inspiring", ReleaseDate = 2024, Rating = 10 }
            );

            modelBuilder.Entity<Review>().HasData(
               new Review { Id = 1, Content = "Amazing and funny movie!", Rating = 9, MovieId = 1, ReviewerId = 1 },
               new Review { Id = 2, Content = " An Outstanding performance.", Rating = 10, MovieId = 2, ReviewerId = 2 },
               new Review { Id = 3, Content = "A mind Blowing performance.", Rating = 9, MovieId = 2, ReviewerId = 3 },
               new Review { Id = 4, Content = "I would recommend this to everyone to watch!", Rating = 9, MovieId = 4, ReviewerId = 1 }
            );

            modelBuilder.Entity<Reviewer>().HasData(
               new Reviewer { Id = 1, FirstName = "Anjorin", LastName = "Oluwadamilola" },
               new Reviewer { Id = 2, FirstName = "Gabriel", LastName = "Anjorin" },
               new Reviewer { Id = 3, FirstName = "Firepemi", LastName = "Bella" },
               new Reviewer { Id = 4, FirstName = "Fifehanmi", LastName = "Anjorin" }
            );
        }
    }
}
