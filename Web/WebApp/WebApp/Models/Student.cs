using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Nullable<int> ClassId { get; set; }

        [ForeignKey("ClassId")]
        public virtual Class? Classes { get; set; }
    }

    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Student>? Students { get; set; }
    }
}