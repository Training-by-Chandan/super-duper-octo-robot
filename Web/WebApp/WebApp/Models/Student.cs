using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [StringLength(15)]
        [Required(ErrorMessage = "Phone number is required")]
        public string Phone { get; set; }

        public Nullable<int> ClassId { get; set; }

        [ForeignKey("ClassId")]
        public virtual Class? Classes { get; set; }
    }
}