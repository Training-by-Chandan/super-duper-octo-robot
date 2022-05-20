using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.CodeFirst.Models
{
    [Table("ProductTbl")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        public string ProductName { get; set; }

        [StringLength(100)]
        public string? Description { get; set; }

        public int? CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }

    [Table("CategoryTbl")]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(100)]
        public string? Description { get; set; }
    }
}