using System.Linq;
using StarWarsMovies.Infrastructure.Dtos;

namespace StarWarsMovies.Infrastructure
{
    public interface IMoviesReviewsManager
    {
        IQueryable<MovieAverageRatingDto> MoviesRatings();
        IQueryable<MovieRatingDto> MovieRatings(int movieId);
        double MovieRatingsAverage(int movieId);
    }
}