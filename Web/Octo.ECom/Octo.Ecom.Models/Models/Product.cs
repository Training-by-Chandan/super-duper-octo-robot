using Octo.ECom.Models.Flags;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Octo.ECom.Models.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string ShortDescription { get; set; }

        public string? LongDescription { get; set; }

        public string? Brand { get; set; }
        public string PicturePath { get; set; }
        public Units Unit { get; set; }
        public double Price { get; set; }
        public double Stock { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}