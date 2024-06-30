using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce_website_skeleton.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public string Email { get; set; }

        public string UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        
        public List<OrderItem> OrderItems { get; set; }
    }
}
