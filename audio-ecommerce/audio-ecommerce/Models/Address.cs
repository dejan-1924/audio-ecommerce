using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace audio_ecommerce.Models
{
    public class Address : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Street { get; set; }

        [StringLength(100)]
        [Required]
        public string City { get; set; }

        [StringLength(50)]
        [Required]
        public string Country { get; set; }

        [StringLength(20)]
        [Required]
        public string ZipCode { get; set; }

        [Required]
        public bool IsShipping { get; set; }
        [Required]
        public bool IsBilling { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public int UserId { get; set; }

        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime ModifiedDate { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
    }
}
