using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class Order
    {
        [Key] public int OrderID { get; set; }
        [Required]
        public bool IsFinished { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }


    }
}
