using System.Linq;
using StarWarsMovies.Db;
using StarWarsMovies.Infrastructure.Dtos;

namespace StarWarsMovies.Infrastructure
{
    public class MoviesReviewsManager : IMoviesReviewsManager
    {
        private readonly MoviesDbContext _moviesDbContext;

        public MoviesReviewsManager(MoviesDbContext moviesDbContext)
        {
            _moviesDbContext = moviesDbContext;
        }

        public IQueryable<MovieAverageRatingDto> MoviesRatings()
        {
            return
                _moviesDbContext.MoviesRatings
                    .GroupBy(movieRating => movieRating.MovieId)
                    .Select(movieRating => new MovieAverageRatingDto(movieRating.Key,
                        movieRating.Average(m => m.Rating))
                    );
        }

        public IQueryable<MovieRatingDto> MovieRatings(int movieId)
        {
            return
                _moviesDbContext.MoviesRatings.Where(movieRating => movieRating.MovieId == movieId)
                    .Select(movieRating => new MovieRatingDto(movieRating.UserId, movieRating.Rating));
        }

        public double MovieRatingsAverage(int movieId)
        {
            return
                _moviesDbContext.MoviesRatings.Where(movieRating => movieRating.MovieId == movieId)
                    .GroupBy(movieRating => movieRating.MovieId)
                    .Select(movieRating => movieRating.Average(m => m.Rating)).FirstOrDefault();
        }
    }
}