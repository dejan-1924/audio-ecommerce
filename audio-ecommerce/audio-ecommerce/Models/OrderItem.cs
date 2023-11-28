using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace audio_ecommerce.Models
{
    public class OrderItem : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        public int OrderId { get; set; }
        [Required]
        public int Quantity { get; set; }

        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime ModifiedDate { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
    }
}
