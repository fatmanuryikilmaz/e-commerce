using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailID { get; set; }
        [ForeignKey("Product")]
        [Required]public int ProductID { get; set; }
        [Required]public int Count { get; set; }
        
        [Required]public double ProductPrice { get; set; }

        [ForeignKey("Order")]
        [Required] public int OrderID { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }


    }
}
