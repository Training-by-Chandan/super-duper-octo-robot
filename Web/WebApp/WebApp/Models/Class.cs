namespace WebApp.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Student>? Students { get; set; }
    }
}