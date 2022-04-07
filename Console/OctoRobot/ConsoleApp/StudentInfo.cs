namespace Octo.Robot
{
    public class StudentInfo
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

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
        private double passMarks = 32;
        private double mathMarks;

        public double MathMarks {
            get {
                return mathMarks;
            }
            set {
                if (value > 100)
                {
                    mathMarks = 100;
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
                scienceMarks = value > 100 ? 100 : value < 0 ? 0 : value;
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
    }
}