using System.Threading.Tasks;
using StarWarsMovies.Infrastructure.Models;

namespace StarWarsMovies.Infrastructure.Services
{
    public interface ISwapiService
    {
        Task<Movies> GetMovies();
        Task<Movie> GetMovie(int id);
    }
}