using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static ZooShop.Infrastructure.Data.DataConstants;

namespace ZooShop.Infrastructure.Data.Models
{
    public class Accessory 
    {
        [Key]
        [Comment("The current Accessory's Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(AccessoriesMaxLength)]
        [Comment("The Name of product category")]
        public string Name { get; set; } = null!;

    }

}
