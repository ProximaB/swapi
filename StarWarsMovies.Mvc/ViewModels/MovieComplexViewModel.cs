using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using StarWarsMovies.Infrastructure.Dtos;
using StarWarsMovies.Infrastructure.Models;

namespace StarWarsMovies.Mvc.ViewModels
{
    public class MovieComplexViewModel
    {
        [DisplayName("MovieId")]
        public int MovieId { get; set; }

        [DisplayName("Average rating")]
        [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
        public double AverageRating { get; set; }

        [DisplayName("Users ratings")]
        public IEnumerable<MovieRatingsViewModel> Ratings { get; set; }

        public string Title { get; set; }

        [DisplayName("Episode No.")]
        public int EpisodeId { get; set; }

        [DisplayName("Opening crawl")]

        public string OpeningCrawl { get; set; }

        public string Director { get; set; }
        public string Producer { get; set; }

        [DisplayName("Release date")]
        public string ReleaseDate { get; set; }

        public IEnumerable<string> Characters { get; set; }
        public IEnumerable<string> Planets { get; set; }
        public IEnumerable<string> Starships { get; set; }
        public IEnumerable<string> Vehicles { get; set; }
        public IEnumerable<string> Species { get; set; }

        public static MovieComplexViewModel Create(IEnumerable<MovieRatingDto> movieRating, Movie movie,
            double movieAverageRating, int movieId)
        {
            var movieViewModel = new MovieComplexViewModel
            {
                MovieId = movieId,
                Ratings = movieRating.Select(m => new MovieRatingsViewModel(m.Rating, m.UserId)),
                Title = movie.Title,
                EpisodeId = movie.EpisodeId,
                OpeningCrawl = movie.OpeningCrawl,
                Director = movie.Director,
                Producer = movie.Producer,
                ReleaseDate = movie.ReleaseDate,
                /*Characters = movie.Characters,
                Planets = movie.Planets,
                Starships = movie.Starships,
                Vehicles = movie.Vehicles,
                Species = movie.Species,*/
                AverageRating = movieAverageRating
            };
            return movieViewModel;
        }
    }
}