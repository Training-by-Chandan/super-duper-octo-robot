using ConsoleApp.EFDemo.Tables;

namespace ConsoleApp.EFDemo.Service
{
    public class TeacherService
    {
        private MyDbContext db = new MyDbContext();

        public void Create()
        {
            //step1.1 take input from user
            var st = new Teacher();
            Console.WriteLine("Enter the firstname");
            st.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the lastname");
            st.LastName = Console.ReadLine();

            db.Teachers.Add(st);
            db.SaveChanges();
        }

        public void ListAll()
        {
            var data = db.Teachers.ToList();
            foreach (var item in data)
            {
                Console.WriteLine($"Id = {item.Id}");
                Console.WriteLine($"FullName = {item.FirstName} {item.LastName}");
            }
        }
    }
}