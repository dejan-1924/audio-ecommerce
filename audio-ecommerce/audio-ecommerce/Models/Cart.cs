using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace audio_ecommerce.Models
{
    public class Cart : IEntity
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime ModifiedDate { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        public double Total { get; set; }

        public Cart()
        {
        }

        public Cart(User user)
        {
            User = user;
            Total = 0.0;
        }
    }
}
