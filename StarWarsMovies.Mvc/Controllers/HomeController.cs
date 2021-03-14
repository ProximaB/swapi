using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StarWarsMovies.Db;
using StarWarsMovies.Db.Enitities;
using StarWarsMovies.Infrastructure;
using StarWarsMovies.Infrastructure.Services;
using StarWarsMovies.Mvc.ViewModels;

namespace StarWarsMovies.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MoviesDbContext _moviesDbContext;
        private readonly IMoviesReviewsManager _moviesReviewsManager;
        private readonly ISwapiService _swapiService;

        public HomeController(ILogger<HomeController> logger,
            MoviesDbContext moviesDbContext, ISwapiService swapiService)
        {
            _moviesDbContext = moviesDbContext;
            _swapiService = swapiService;
            _moviesReviewsManager = new MoviesReviewsManager(_moviesDbContext);
            _logger = logger;
        }

        public async Task<ActionResult> Index()
        {
            var movies = await _swapiService.GetMovies();
            var moviesRatings = _moviesReviewsManager.MoviesRatings().AsEnumerable();

            var moviesSlimViewModel = MoviesSlimViewModel.Create(movies, moviesRatings);

            return View(moviesSlimViewModel);
        }

        public async Task<IActionResult> Movie([Required] [Range(1, 6)] int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var movie = await _swapiService.GetMovie(id);
            var movieRatings = _moviesReviewsManager.MovieRatings(id).AsEnumerable();
            var movieAverageRating = _moviesReviewsManager.MovieRatingsAverage(id);

            var movieComplexViewModel = MovieComplexViewModel.Create(movieRatings, movie, movieAverageRating, id);

            return View(movieComplexViewModel);
        }

        public async Task<IActionResult> RateMovie([Required] [Range(1, 6)] int movieId,
            [Required] [Range(1, 10)] int rating)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            _moviesDbContext.MoviesRatings.Update(new MovieRating
            {
                MovieId = movieId,
                Rating = rating,
                UserId = new Random().Next(20)
            });
            await _moviesDbContext.SaveChangesAsync();

            return RedirectToAction("Movie", new {id = movieId});
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}