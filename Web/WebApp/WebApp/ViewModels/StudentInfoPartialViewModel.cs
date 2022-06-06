namespace WebApp.ViewModels
{
    public class StudentInfoPartialViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Class { get; set; }
       public StudentClassTeacherViewModel ClassTeacher { get; set; }
    }
    public class StudentClassTeacherViewModel
    {
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
    }

}