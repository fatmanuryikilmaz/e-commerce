using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class Product
    {
        [Required]
        public int ProductID { get; set; }

        [Required]
        public string ProductName { get; set; }
        [Required]
        public double ProductPrice { get; set; }
        [Required] 
        public string ProductDescription { get; set; }
        [Required]
        public int Count { get; set; }

        public string ProductImage { get; set; }
        [ForeignKey("Category")]
        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
