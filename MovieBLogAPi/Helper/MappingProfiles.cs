using AutoMapper;
using MovieBlogAPI.Dto;
using MovieBlogAPI.Models;

namespace MovieBlogAPI.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Movie, MovieDto>();
            CreateMap<MovieDto, Movie>();
            CreateMap<Movie, GetMovieDto>();
            CreateMap<GetMovieDto, Movie>();
            CreateMap<Review, ReviewDto>();
            CreateMap<ReviewDto, Review>();
            CreateMap<Review, GetReviewDto>();
            CreateMap<GetReviewDto, Review>();
            CreateMap<Reviewer, ReviewerDto>();
            CreateMap<ReviewerDto, Reviewer>();
            CreateMap<Reviewer, GetReviewerDto>();
            CreateMap<GetReviewerDto, Reviewer>();


        }
    }
}
