using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Octo.Robot
{
    [Sys("Test")]
    public class StudentInfo
    {
        public const int a1 = 53;
        public readonly int a2 = 2;
        private int a4 = 3;
        public int a3 { get => a4; }

        public StudentInfo(StudentInfo studentInfo)
        {
            this.scienceMarks = studentInfo.scienceMarks;
            //this = studentInfo;//not valid
        }

        public StudentInfo()
        {
            // a1 = 20;
            a2 = 30;
        }

        private void Test()
        {
            //a1 = 10;
            //a2 = 20;
            //a3 = 30;
            a4 = 20;
        }

        #region Properties

        [Sys("Test")]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }
        public string LastName { get; set; }
        private string Testing { get; set; }

        public string GetFullName()
        {
            if (string.IsNullOrWhiteSpace(MiddleName))
            {
                return $"{FirstName} {LastName}";
            }
            else
            {
                return $"{FirstName} {MiddleName} {LastName}";
            }
        }

        public string FullName {
            get {
                if (string.IsNullOrWhiteSpace(MiddleName))
                {
                    return $"{FirstName} {LastName}";
                }
                else
                {
                    return $"{FirstName} {MiddleName} {LastName}";
                }
            }
        }

        private double fullMarks = 100;

        public double FullMarks {
            get => fullMarks;
            set => fullMarks = value;
        }

        private double passMarks = 32;

        public double PassMarks {
            get => passMarks;
            set => passMarks = value;
        }

        private double mathMarks;

        public double MathMarks {
            get {
                return mathMarks;
            }
            set {
                if (value > fullMarks)
                {
                    mathMarks = fullMarks;
                }
                else if (value < 0)
                {
                    mathMarks = 0;
                }
                else
                {
                    mathMarks = value;
                }
            }
        }

        private double scienceMarks;

        public double ScienceMarks {
            get { return scienceMarks; }
            set {
                scienceMarks = value > fullMarks ? fullMarks : value < 0 ? 0 : value;
            }
        }

        public double Total {
            get {
                return System.Math.Round(ScienceMarks + MathMarks, 2);
            }
        }

        public double PercentageNum {
            get {
                return System.Math.Round((Total / (2 * fullMarks) * 100), 2);
            }
        }

        public string Percentage {
            get {
                return PercentageNum.ToString("00.00") + " %";
            }
        }

        public string Division {
            get {
                if (PercentageNum >= 80) return "Distinction";
                else if (PercentageNum >= 60) return "First Division";
                else if (PercentageNum >= 45) return "Second Division";
                else if (PercentageNum >= 32) return "Third Division";
                else return "Fail";
            }
        }

        #endregion Properties

        #region Functions

        public void Display()
        {
            int x = 0;
            switch (x)
            {
                case 1:
                    return;

                default:
                    break;
            }
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    return;
                }
            }
            //next statments
        }

        public int Adds(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Adds two numbers
        /// </summary>
        /// <param name="a">First parameter</param>
        /// <param name="b">Second parameter</param>
        /// <returns>Integer value after adding a and b</returns>
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Add(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }

        public int Add(int[] x)
        {
            return x.Sum();
        }

        public void DoSomething(in int a, in string b, float c)
        {
            c = 20f;
            //we are doing something here
        }

        public void FunctionOne(int a, out int x)
        {
            x = 10;
        }

        public void FunctionThree(ref int x)
        {
            x = 10;
            x = x + 6;
            Add(x, 6);
        }

        public (int, string, float, int) FunctionFour()
        {
            return (1, "", 1f, 1);
        }

        public (int, string, float, int) FunctionFive((int, string) a)
        {
            a.Item1 = 10;
            return (1, "", 1f, 1);
        }

        public void FunctionTwo(string str = "String", int i = 10)
        {
        }

        #endregion Functions

        #region Operator Overloading

        public static StudentInfo operator +(StudentInfo a, StudentInfo b)
        {
            var final = new StudentInfo();
            final.FirstName = a.FirstName;
            final.MiddleName = a.MiddleName;
            final.LastName = a.LastName;
            final.FullMarks = a.FullMarks + b.FullMarks;
            final.PassMarks = a.PassMarks + b.PassMarks;
            final.ScienceMarks = a.ScienceMarks + b.ScienceMarks;
            final.MathMarks = a.MathMarks + b.MathMarks;

            return final;
        }

        public static StudentInfo operator ++(StudentInfo a)
        {
            a.MathMarks++;
            a.scienceMarks++;

            return a;
        }

        public static StudentInfo operator +(StudentInfo a, double b)
        {
            return AddStudentInfoWithNum(b, a);
        }

        public static StudentInfo operator +(double b, StudentInfo a)
        {
            return AddStudentInfoWithNum(b, a);
        }

        private static StudentInfo AddStudentInfoWithNum(double b, StudentInfo a)
        {
            a.MathMarks += b;
            a.ScienceMarks += b;

            return a;
        }

        public static bool operator ==(StudentInfo a, StudentInfo b)
        {
            return (a.FullMarks == b.FullMarks && a.PassMarks == b.PassMarks && a.ScienceMarks == b.ScienceMarks && a.MathMarks == b.MathMarks);
        }

        public static bool operator !=(StudentInfo a, StudentInfo b)
        {
            return !(a.FullMarks == b.FullMarks && a.PassMarks == b.PassMarks && a.ScienceMarks == b.ScienceMarks && a.MathMarks == b.MathMarks);
        }

        #endregion Operator Overloading
    }
}