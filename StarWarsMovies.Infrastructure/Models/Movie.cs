using System.Text.Json.Serialization;

namespace StarWarsMovies.Infrastructure.Models
{
    public class Movie
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("episode_id")]
        public int EpisodeId { get; set; }

        [JsonPropertyName("opening_crawl")]
        public string OpeningCrawl { get; set; }

        [JsonPropertyName("director")]
        public string Director { get; set; }

        [JsonPropertyName("producer")]
        public string Producer { get; set; }

        [JsonPropertyName("release_date")]
        public string ReleaseDate { get; set; }

        //     [JsonPropertyName("characters")]
        //     public IEnumerable<string> Characters { get; set; }
        //  
        //     [JsonPropertyName("planets")]
        //     public IEnumerable<string> Planets { get; set; }
        //  
        //     [JsonPropertyName("starships")]
        //     public IEnumerable<string> Starships { get; set; }
        //  
        //     [JsonPropertyName("vehicles")]
        //     public IEnumerable<string> Vehicles { get; set; }
        //  
        //     [JsonPropertyName("species")]
        //     public IEnumerable<string> Species { get; set; }

        //     [JsonPropertyName("created")]
        //     public DateTime Created { get; set; }
        //
        //     [JsonPropertyName("edited")]
        //     public DateTime Edited { get; set; }
        //
        //     [JsonPropertyName("url")]
        //     public string Url { get; set; }
    }
}