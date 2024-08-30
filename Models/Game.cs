using Microsoft.Identity.Client;

namespace RelationsNaN.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int ReleaseYear { get; set; }

        public int? GenreId { get; set; }
        public Genre? Genre { get; set; }
    }
}
