using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace audio_ecommerce.Models
{
    public class Product : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public ICollection<Genre> Genres { get; set; } = new List<Genre>();
        [ForeignKey("ArtistId")]
        public Artist Artist { get; set; } = null!;
        public int ArtistId { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime ModifiedDate { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        public double Price { get; set; }
        [Required]
        public int Amount { get; set; }
        public string ImageUrl { get; set; }
    }
}
