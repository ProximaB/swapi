using System.Collections.Generic;

namespace StarWarsMovies.Infrastructure.Dtos
{
    public record MovieRatingsDto(int Id, int RatingAvg, IEnumerable<MovieRatingDto> MovieRatings);
}