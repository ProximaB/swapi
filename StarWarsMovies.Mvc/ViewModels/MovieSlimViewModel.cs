using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using StarWarsMovies.Infrastructure.Dtos;
using StarWarsMovies.Infrastructure.Models;

namespace StarWarsMovies.Mvc.ViewModels
{
    public class MovieSlimViewModel
    {
        [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
        public double Rating { get; set; }

        public string Title { get; set; }

        public int EpisodeId { get; set; }

        public string ReleaseDate { get; set; }

        public int MovieId { get; set; }
    }

    public class MoviesSlimViewModel
    {
        public IEnumerable<MovieSlimViewModel> Movies { get; set; }

        public static MoviesSlimViewModel Create(Movies movies,
            IEnumerable<MovieAverageRatingDto> moviesRating)
        {
            return new()
            {
                Movies = movies.Results.Select((movie, index) =>
                {
                    var model = new MovieSlimViewModel
                    {
                        MovieId = index + 1,
                        Title = movie.Title,
                        EpisodeId = movie.EpisodeId,
                        ReleaseDate = movie.ReleaseDate
                    };
                    model.Rating = moviesRating
                        .FirstOrDefault(movieAverageRating => movieAverageRating.MovieId == model.MovieId)?.Rating ?? 0;

                    return model;
                })
            };
        }
    }
}