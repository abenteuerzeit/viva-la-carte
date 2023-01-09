using System.ComponentModel.DataAnnotations;

namespace VLC.Models.Products
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = "default product name";
    }
}
