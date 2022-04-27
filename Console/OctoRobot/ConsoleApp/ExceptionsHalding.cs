using System;
using System.Diagnostics;
using System.Text;

namespace Octo.Robot
{
    public class ExceptionsHalding
    {
        public static void Run()
        {
            try
            {
                Console.WriteLine("Enter the choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                Choices(choice);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine("Not Supported");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format");
            }
            catch (Exception ex)
            {
                Console.WriteLine("handling exception");
            }
        }

        private static void Choices(int choice)
        {
            if (choice == 1)
            {
                throw new NotSupportedException("This is not supported");
            }
            else if (choice < 0)
            {
                throw new LessthanZeroException("Value must be greater than 0");
            }
            else if (choice > 10)
            {
                throw new ArgumentOutOfRangeException("Value must be in between 1 and 10");
            }
        }
    }

    [Serializable]
    public class LessthanZeroException : Exception
    {
        public LessthanZeroException()
        {
            Log();
        }

        public LessthanZeroException(string message) : base(message)
        {
            Log();
        }

        private static void Log()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine("============================================");
            sb.AppendLine("Exception occured here in less than zero exception");
            StackTrace st = new StackTrace();
            sb.AppendLine(st.ToString() + "\n\n");

            var path = $"logs-{DateTime.Now.ToString("yyyy-MMM-dd")}.txt";
            System.IO.File.AppendAllText(path, sb.ToString());
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "Application";
                eventLog.WriteEntry(sb.ToString(), EventLogEntryType.Error, 101, 1);
            }
            //write the code to write the log in db or some file
        }
    }
}