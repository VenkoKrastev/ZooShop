using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooShop.Infrastructure.Data.Models
{
    public class AccessoryCategory
    {
        [Key]
        public int Id { get; set; }
        [Required] 
        public int CategoriesId { get; set; }
        [ForeignKey(nameof(CategoriesId))]
        public Category? Category { get; set; }

        [Required]
        public int AccessoriesId { get; set; }
        [ForeignKey(nameof(AccessoriesId))]
        public Accessory? Accessory { get; set; } 
    }
}
