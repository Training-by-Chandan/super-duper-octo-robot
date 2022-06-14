using System.ComponentModel.DataAnnotations;

namespace Octo.ECom.Models.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        public int? CategoryId { get; set; }

        public string? ParentCategoryName { get; set; }
    }
}