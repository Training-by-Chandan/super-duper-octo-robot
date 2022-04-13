using System;
using System.Collections.Generic;
using System.Text;

namespace Octo.Robot
{
    public class Program
    {
        private static void Main()
        {
            var res = "N";
            do
            {
                //DataTypes();
                //ConditionalStatement();
                //Looping();
                //StringConcat();
                //Arrays();
                //DateTimes();
                //ClassAndObjects();
                //PropertiesEaxmple();
                //FunctionsExampleV1();
                //OperatorOverloading();
                //StaticAndNonStatic();
                //InheritanceExample();
                ShapesExample();

                Console.WriteLine("Do you want to continue more? (Y/N)");
                res = Console.ReadLine();
            } while (res.ToUpper() == "Y");
        }

        private static void ShapesExample()
        {
            Console.WriteLine("Press 1 for Circle, 2 for Rectangle and 3 for Square");
            var choice = Convert.ToInt32(Console.ReadLine());
            var shape = ShapeFactory(choice);
            shape.GetInput();
            shape.Area();
            shape.Perimeter();
        }

        private static IShape ShapeFactory(int i)
        {
            switch (i)
            {
                case 1:
                    return new Circle();

                case 2:
                    return new Rectangle();

                case 3:
                    return new Triangle();

                default:
                    return new Square();
            }
        }

        private static void InheritanceExample()
        {
            LivingThings l1 = new LivingThings(1);
            Animal a = new Animal();
            Plants p1 = new Plants();
            Vertibrates v1 = new Vertibrates();
            Vertibrates v2 = new Vertibrates(1);

            LivingThings a2 = new Animal();
            Console.WriteLine("\nfrom living thin object");
            l1.Eat();
            Console.WriteLine("\nfrom animal object");
            a.Eat();
            Console.WriteLine("\nfrom animal object converted to living thing");
            a2.Eat();
            LivingThings p2 = new Plants();
            Console.WriteLine("\nfrom plant object");
            p2.Eat();
            LivingThings v3 = new Vertibrates();
            Console.WriteLine("\nfrom vertibrate object converted to living things");
            v3.Eat();
            LivingThings h1 = new Human();
            Console.WriteLine("\nfrom human object converted to living things");
            h1.Eat();

            Console.WriteLine(l1.ToString());
        }

        private static void StaticAndNonStatic()
        {
            StaticClass.J = 30;
            StaticClass.FunctionOne();

            NonStaticClass s1 = new NonStaticClass();
            s1.i = 1;
            s1.j = 1;
            s1.FunctionOne();

            NonStaticClass.istatic = 10;
            NonStaticClass.jstatic = 20;
            NonStaticClass.StaticFunctionOne();
            Console.WriteLine();
        }

        private static void OperatorOverloading()
        {
            int i = 10;
            int j = 20;
            int k = i + j;

            StudentInfo s1 = new StudentInfo();
            s1.FirstName = "Bishal";
            s1.MiddleName = "Kumar";
            s1.LastName = "Yonghang";
            s1.ScienceMarks = 50;
            s1.MathMarks = 57;
            StudentInfo s2 = new StudentInfo();
            s2.FirstName = "Bishal";
            s2.MiddleName = "Kumar";
            s2.LastName = "Yonghang";
            s2.ScienceMarks = 50;
            s2.MathMarks = 57;

            var final = new StudentInfo();
            final.FirstName = "Bishal";
            final.MiddleName = "Kumar";
            final.LastName = "Yonghang";
            final.FullMarks = s1.FullMarks + s2.FullMarks;
            final.PassMarks = s1.PassMarks + s2.PassMarks;
            final.ScienceMarks = s1.ScienceMarks + s2.ScienceMarks;
            final.MathMarks = s1.MathMarks + s2.MathMarks;

            //s1++;
            var finalv2 = s1 + s2 + s1 + s2;
            //s1 = 2 + s1 + 2;

            //Console.WriteLine(s1 == s1);
            Console.WriteLine(s1 == s2);
        }

        private static void FunctionsExampleV1()
        {
            //TODO left for chandan
            StudentInfo s1 = new StudentInfo();
            s1.DoSomething(b: "", c: 1f, a: 1);
            s1.DoSomething(1, "", 1f);
            s1.DoSomething(1, c: 1f, b: "");

            s1.FunctionTwo();
            int b = 0;
            int c = 0;
            int e = 0;
            var res = s1.Add(1, 1);

            s1.FunctionOne(5, out c);
            s1.FunctionThree(ref b);
            res = s1.Add(1, 1);
            var d = s1.FunctionFour();
            Console.WriteLine();
            res = s1.Add(1, 1);
        }

        private static void PropertiesEaxmple()
        {
            //todo left for Santosh
            //HumanBeings h1 = new HumanBeings();
            //h1.First_Name = "Chandan";
            //Console.WriteLine(h1.First_Name);
            StudentInfo s1 = new StudentInfo();
            s1.FirstName = "Bishal";
            s1.MiddleName = "Kumar";
            s1.LastName = "Yonghang";
            Console.WriteLine(s1.FullName);
            Console.WriteLine("\nWhen the value is greater than 100\n========================");
            s1.ScienceMarks = 101;
            s1.MathMarks = 57;
            Console.WriteLine($"Science = {s1.ScienceMarks}\nMath = {s1.MathMarks}\nTotal = {s1.Total}\nPercentage = {s1.Percentage}\nDivision = {s1.Division}");

            Console.WriteLine("\nWhen the value is less than 0\n========================");
            s1.ScienceMarks = -101;
            s1.MathMarks = 67.53;
            Console.WriteLine($"Science = {s1.ScienceMarks}\nMath = {s1.MathMarks}\nTotal = {s1.Total}\nPercentage = {s1.Percentage}\nDivision = {s1.Division}");

            Console.WriteLine("\nWhen the value is between 0 and 100\n========================");
            s1.ScienceMarks = 4.83;
            s1.MathMarks = 3.54;
            Console.WriteLine($"Science = {s1.ScienceMarks}\nMath = {s1.MathMarks}\nTotal = {s1.Total}\nPercentage = {s1.Percentage}\nDivision = {s1.Division}");
        }

        private static void ClassAndObjects()
        {
            HumanBeings h1 = new HumanBeings();
            Console.WriteLine(h1.GetHashCode());
            h1 = new HumanBeings();
            Console.WriteLine(h1.GetHashCode());

            HumanBeings h2 = new HumanBeings("Ramesh");
            HumanBeings h3 = new(1, "Suresh");
            var h4 = new HumanBeings("Suresh", 20);
        }

        private static void DateTimes()
        {
            TimeZone();
            Console.WriteLine();
            var datenow = DateTime.Now;
            var dateatr = DateTime.Now.ToString("MMM dd, yyyy hh:mm:ss tt");
            Console.WriteLine($"Nepal => {dateatr}");

            //Gets the list of standard timezone info

            Console.WriteLine($"Central Standard Time => {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "Central Standard Time")}");

            DateTime dt = new DateTime(1990, 03, 23);
            var diff = DateTime.Now - dt;
            Console.WriteLine($"{diff.TotalDays / 365}");
        }

        private static void TimeZone()
        {
            var timezoneInfo = TimeZoneInfo.GetSystemTimeZones();
            foreach (var item in timezoneInfo)
            {
                Console.WriteLine(item.StandardName);
            }
        }

        private static void Arrays()
        {
            var days = "Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday";
            var arr = days.Split(",");
            //initialization
            var arr1 = new int[] { 1, 2, 3, 4, 5, 6 };
            var arr2 = new int[3];
            var newArr = new int[5];
            newArr[0] = 10;
            newArr[1] = 13;
            newArr[2] = 12;
            newArr[3] = 15;
            newArr[4] = 14;
            Array.Resize(ref newArr, newArr.Length + 1);
            Array.Sort(newArr);
            Array.Reverse(newArr);
            Array.Copy(arr1, arr2, 3);
            Array.Copy(arr1, 3, arr2, 1, 2);
            Array.Copy(arr1, 1, arr2, 0, 3);

            //newArr[5] = 18;
            //0 to n-1 : 0 to 4
        }

        private static void StringConcat()
        {
            string a = "Hello";
            string b = "Everyone";

            //string concatenation
            Console.WriteLine("\nUsing String Concatenation\n===============================");
            string c = a + " " + b;
            Console.WriteLine(c);

            //string formatting
            //string[] str = new string[] { "Hello", "Everyone", "Broadway" };
            Console.WriteLine("\nUsing String Formatting\n===============================");
            string template = "Hi! {0}, we welcome you";
            string result1 = string.Format(template, "Chandan", "Test");
            Console.WriteLine(result1);
            Console.WriteLine(template, "Broadway");

            //string interpolation
            Console.WriteLine("\nUsing String Interpolation\n===============================");
            string result2 = $"Hi {b}, we welcome you";
            Console.WriteLine(result2);

            //string builder
            Console.WriteLine("\nUsing String Builder\n===============================");
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lorem ipsum dolor sit amet consectetur adipisicing elit. Eaque odit id totam consectetur hic velit minima veritatis doloremque magnam! Quia dolor quis eum, ut dicta perspiciatis sapiente illum laborum aliquid.");
            sb.AppendLine("Lorem ipsum dolor sit amet consectetur adipisicing elit. Eaque odit id totam consectetur hic velit minima veritatis doloremque magnam! Quia dolor quis eum, ut dicta perspiciatis sapiente illum laborum aliquid.");
            sb.AppendLine("Lorem ipsum dolor sit amet consectetur adipisicing elit. Eaque odit id totam consectetur hic velit minima veritatis doloremque magnam! Quia dolor quis eum, ut dicta perspiciatis sapiente illum laborum aliquid.");
            sb.AppendLine("Lorem ipsum dolor sit amet consectetur adipisicing elit. Eaque odit id totam consectetur hic velit minima veritatis doloremque magnam! Quia dolor quis eum, ut dicta perspiciatis sapiente illum laborum aliquid.");
            sb.AppendLine("Lorem ipsum dolor sit amet consectetur adipisicing elit. Eaque odit id totam consectetur hic velit minima veritatis doloremque magnam! Quia dolor quis eum, ut dicta perspiciatis sapiente illum laborum aliquid.");
            sb.AppendLine("Lorem ipsum dolor sit amet consectetur adipisicing elit. Eaque odit id totam consectetur hic velit minima veritatis doloremque magnam! Quia dolor quis eum, ut dicta perspiciatis sapiente illum laborum aliquid.");
            sb.AppendLine("Lorem ipsum dolor sit amet consectetur adipisicing elit. Eaque odit id totam consectetur hic velit minima veritatis doloremque magnam! Quia dolor quis eum, ut dicta perspiciatis sapiente illum laborum aliquid.");
            sb.AppendLine("Lorem ipsum dolor sit amet consectetur adipisicing elit. Eaque odit id totam consectetur hic velit minima veritatis doloremque magnam! Quia dolor quis eum, ut dicta perspiciatis sapiente illum laborum aliquid.");
            Console.WriteLine(sb.ToString());

            //some string functions
            var days = "      Sunday, Monday, Tuesday   , Wednesday, Thursday, Friday, Saturday     ";
            Console.WriteLine(days.TrimStart());
        }

        private static void Looping()
        {
            //Requirements : Initialization, Breaking condition, increment

            //Unknown Quantity
            //While: First Check then execute, do while: First execute then check
            //while loop
            //while (true)
            //{
            //this code is infinite loop
            //}

            //do while
            //do
            //{
            //} while (true);

            //known quantity
            //for loop
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j == 2) break;
                }
                if (i == 5) break;

                Console.WriteLine(i);
                //continue / break
            }

            //
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

            var days = "";
            if (num == 1) days = "Sunday";
            else if (num == 2) days = "Monday";
            else if (num == 3) days = "Tuesday";
            else if (num == 4) days = "Wednesday";
            else if (num == 5) days = "Thursday";
            else if (num == 6) days = "Friday";
            else if (num == 7) days = "Saturday";
            else days = "Not a valid day";

            var daytype = "";
            if (num == 1 || num == 7)
            {
                daytype = "Weekends";
            }
            else if (num == 2 || num == 3 || num == 4 || num == 5 || num == 6)
            {
                daytype = "Weekdays";
            }
            else
            {
                daytype = "Not valid day type";
            }

            daytype = (num == 1 || num == 7) ? "Weekends" : (num == 2 || num == 3 || num == 4 || num == 5 || num == 6) ? "Weekdays" : "Not a valid daytype";

            //tenary operator : (condition) ? <true values> : false values;
            days = num == 1 ? "Sunday" : num == 2 ? "Monday" : num == 3 ? "Tuesday" : num == 4 ? "Wednesday" : num == 5 ? "Thursday" : num == 6 ? "Friday" : num == 7 ? "Saturday" : "Not a valid day";

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

            switch (num)
            {
                case 1:
                case 7:
                    daytype = "Weekends";
                    break;

                case int n when (n >= 2 && n <= 6):
                    daytype = "Weekdays";
                    break;

                default:
                    daytype = "Not a valid day type";
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