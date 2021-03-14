using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StarWarsMovies.Db.Enitities
{
    public class MovieRating
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(1, 10)]
        [DefaultValue(1)]
        public int Rating { get; set; }

        //mvc
        // [ForeignKey("MovieId")]
        // public Movie Movie { get; set; }
        [Required]
        public int MovieId { get; set; }

        //mvc
        //[ForeignKey("UserId")]
        //public User User { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}