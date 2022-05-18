using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp.Data
{
    public class DbConnector
    {
        //1. Write the connection string
        private const string conString = "server=DESKTOP-PT71T7O\\SQLCHANDAN;database=db8am;integrated security=true";

        public void ReadInfomationTable()
        {
            //2. Create a connection Object
            SqlConnection connection = new SqlConnection(conString);

            //3. Write the query
            string query = "select * from infomation";

            //4. Create a command object with connection object and query
            SqlCommand cmd = new SqlCommand(query, connection);

            //5. Connection open
            connection.Open();

            //6. execute the command
            var result = cmd.ExecuteReader();

            //7. Process the result
            while (result.Read())
            {
                Console.WriteLine($"Id = {result.GetFieldValue<int>(0)}");
                Console.WriteLine($"Fullname = {result.GetFieldValue<string>(1)} {result.GetFieldValue<string>(2)}");
            }
            //8. Close the connection
            connection.Close();
        }

        public void AddData()
        {
            //step1.1 take input from user
            Console.WriteLine("Enter the firstname");
            var first = Console.ReadLine();
            Console.WriteLine("Enter the lastname");
            var last = Console.ReadLine();

            //2. Create a connection Object
            SqlConnection connection = new SqlConnection(conString);

            //3. Write the query
            string query = $"insert into infomation (firstname,lastname) values ('{first}','{last}')";

            //4. Create a command object with connection object and query
            SqlCommand cmd = new SqlCommand(query, connection);

            //5. Connection open
            connection.Open();

            //6. execute the command
            var result = cmd.ExecuteNonQueryAsync();

            //8. Close the connection
            connection.Close();
        }

        public void EditData()
        {
            //step1.1 take input from user
            Console.WriteLine("Enter the Id");
            var id = Console.ReadLine();
            Console.WriteLine("Enter the firstname");
            var first = Console.ReadLine();
            Console.WriteLine("Enter the lastname");
            var last = Console.ReadLine();

            //2. Create a connection Object
            SqlConnection connection = new SqlConnection(conString);

            //3. Write the query
            string query = $"update infomation set firstname='{first}', lastname='{last}' where id={id}";

            //4. Create a command object with connection object and query
            SqlCommand cmd = new SqlCommand(query, connection);

            //5. Connection open
            connection.Open();

            //6. execute the command
            var result = cmd.ExecuteNonQueryAsync();

            //8. Close the connection
            connection.Close();
        }

        public void DeleteData()
        {
            //step1.1 take input from user
            Console.WriteLine("Enter the Id");
            var id = Console.ReadLine();

            //2. Create a connection Object
            SqlConnection connection = new SqlConnection(conString);

            //3. Write the query
            string query = $"delete from infomation where id={id}";

            //4. Create a command object with connection object and query
            SqlCommand cmd = new SqlCommand(query, connection);

            //5. Connection open
            connection.Open();

            //6. execute the command
            var result = cmd.ExecuteNonQueryAsync();

            //8. Close the connection
            connection.Close();
        }
    }
}