using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    //admin: Fatmanur şifre:1111
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        [Required]
        public string AdminName { get; set; }
        [Required]
        public string AdminPassword { get; set; }

    }
}
