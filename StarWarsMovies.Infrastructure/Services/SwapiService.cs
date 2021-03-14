using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using StarWarsMovies.Infrastructure.Models;

namespace StarWarsMovies.Infrastructure.Services
{
    public class SwapiService : ISwapiService
    {
        private readonly HttpClient _httpClient;
        private readonly Uri _remoteServiceBaseUrl = new("https://swapi.dev/api/");

        public SwapiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = _remoteServiceBaseUrl;
        }

        public async Task<Movies> GetMovies()
        {
            var responseMessage = await _httpClient.GetAsync("films/");

            Movies movies = null;
            if (responseMessage.IsSuccessStatusCode)
            {
                var moviesJsonResponse = responseMessage.Content.ReadAsStringAsync().Result;
                movies = JsonSerializer.Deserialize<Movies>(moviesJsonResponse);
            }

            return movies;
        }

        public async Task<Movie> GetMovie(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"films/{id.ToString()}/");

            Movie movies = null;
            if (responseMessage.IsSuccessStatusCode)
            {
                var moviesJsonResponse = responseMessage.Content.ReadAsStringAsync().Result;
                movies = JsonSerializer.Deserialize<Movie>(moviesJsonResponse);
            }

            return movies;
        }
    }
}