using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApp.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public double Stock { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}