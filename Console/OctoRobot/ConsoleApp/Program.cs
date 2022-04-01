using System;

namespace Octo.Robot
{
    public class Program
    {
        private static void Main()
        {
            //DataTypes();
            ConditionalStatement();
        }

        //Conditional Statements
        public static void ConditionalStatement()
        {
            Console.WriteLine("Enter a number");
            var num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
                Console.WriteLine("Sunday");
            else if (num == 2) Console.WriteLine("Monday");
            else if (num == 3) Console.WriteLine("Tuesday");
            else if (num == 4) Console.WriteLine("Wednesday");
            else if (num == 5) Console.WriteLine("Thursday");
            else if (num == 6) Console.WriteLine("Friday");
            else if (num == 7) Console.WriteLine("Saturday");
            else Console.WriteLine("Not a valid day");

            var day = "";
            if (num == 1) day = "Sunday";
            else if (num == 2) day = "Monday";
            else if (num == 3) day = "Tuesday";
            else if (num == 4) day = "Wednesday";
            else if (num == 5) day = "Thursday";
            else if (num == 6) day = "Friday";
            else if (num == 7) day = "Saturday";
            else day = "Not a valid day";

            //tenary operator : (condition) ? <true values> : false values;
            day = num == 1 ? "Sunday" : num == 2 ? "Monday" : num == 3 ? "Tuesday" : num == 4 ? "Wednesday" : num == 5 ? "Thursday" : num == 6 ? "Friday" : num == 7 ? "Saturday" : "Not a valid day";

            Console.WriteLine("Enter a number");
            var number = Convert.ToInt32(Console.ReadLine());
            var output = number % 2 == 0 ? "Even" : "Odd";
            if (number % 2 == 0)
            {
                output = "Even";
            }
            else
            {
                output = "Odd";
            }
            Console.WriteLine("Number is " + output);

            switch (num)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;

                case 2:
                    Console.WriteLine("Monday");
                    break;

                case 3:
                    Console.WriteLine("Tuesday");
                    break;

                case 4:
                    Console.WriteLine("Wednesday");
                    break;

                case 5:
                    Console.WriteLine("Thursday");
                    break;

                case 6:
                    Console.WriteLine("Friday");
                    break;

                case 7:
                    Console.WriteLine("Saturday");
                    break;

                default:
                    Console.WriteLine("Not a valid day");
                    break;
            }
        }

        private static void Casting()
        {
            //implicit / explicit / type conversion class (Convert)

            //int i = 12;
            //i = 13;
            //float f = 12;
            //double d = 12d;
            //decimal de = 12m;

            //implicit casting
            // char => int => long => float => double
            char c = 'C';
            int i = c;
            long l = i;
            float f = l;
            double d = f;

            // explicit casting
            f = (float)d;
            l = (long)f;
            i = (int)l;

            //string
            string str = i.ToString();
            object o = "abc";
            o = 123;
            o = f;
            o = l;
            str = o.ToString();

            //Type Conversion Class
            str = "123";

            float.TryParse("123.344", out f);

            var a = 12f;
            // a = "";

            var a1 = "";
            var a2 = 12;

            object o1 = "";
            object o2 = 12;

            var idNew = Guid.NewGuid();
            var id = Guid.NewGuid();

            var st = Console.ReadLine();
        }

        public static void DataTypes()
        {
            //bool: true / false: 1 bit 0/1
            //char :1 bytes : unicode => 16 bits
            //string : n bytes
            //sbyte : 1 byte both positive and negative

            //short : int 16 bits: both positive and negative
            short s = -32768;
            //ushort : 16 bit int: only positive
            ushort us = 65535;
            //int : int 32 bit : both positive and negative
            //uint : unsigned int 32 bit : positive
            uint ui = 4294967295;
            //long : int 64 bit : both positive and negative
            //ulong : unsigned int 64 bit : positive
            //float : 4 bytes
            //double : 8 bytes
            //decimal : 16 bytes
            //DateTime
        }
    }
}