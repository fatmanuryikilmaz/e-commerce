using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class Category
    {
        [Key] public int CategoryID { get; set; }
        [Required]public string CategoryName { get; set; }
        public string CategoryImage { get; set; }
        [Required]public string CategoryNDescription { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
