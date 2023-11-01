using System.ComponentModel.DataAnnotations;

namespace GameCatalog.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required]//validation
        [StringLength(50)]//namelengh
        public required string Name { get; set; }
        [Required]
        [StringLength(20)]
        public required string Grenre { get; set; }
        [Range(1,100)]//price range
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
