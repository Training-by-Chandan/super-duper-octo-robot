using ConsoleApp.EFDemo.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.EFDemo.Service
{
    public class StudentService
    {
        private MyDbContext db = new MyDbContext();

        public void Create()
        {
            //step1.1 take input from user
            Student st = new Student();
            Console.WriteLine("Enter the firstname");
            st.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the lastname");
            st.LastName = Console.ReadLine();

            db.Students.Add(st);
            db.SaveChanges();
        }

        public void ListAll()
        {
            var data = db.Students.ToList();
            foreach (var item in data)
            {
                Console.WriteLine($"Id = {item.Id}");
                Console.WriteLine($"FullName = {item.FirstName} {item.LastName}");
            }
        }
    }
}