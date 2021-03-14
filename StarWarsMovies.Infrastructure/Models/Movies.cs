using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace StarWarsMovies.Infrastructure.Models
{
    public class Movies
    {
        // [JsonPropertyName("count")]
        // public int Count { get; set; }
        //
        // [JsonPropertyName("next")]
        // public object Next { get; set; }
        //
        // [JsonPropertyName("previous")]
        // public object Previous { get; set; }

        [JsonPropertyName("results")]
        public IEnumerable<Movie> Results { get; set; }
    }
}