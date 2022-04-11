namespace Octo.Robot
{
    //Access modifiers: public / private / protected / internal / internal protected
    public class HumanBeings
    {
        //1. Constructors
        //a. Special Function
        //b. Does not return
        //c. Name is same as that of Class name
        //d. Runs only once in its lifetime
        //e. Can be overloaded
        //f. mostly public, in some cases static and in some cases protected
        public HumanBeings()
        {
            _fname = "Babu";
        }

        public HumanBeings(string name) //string
        {
            _fname = name;
        }

        public HumanBeings(string firstname, string lastname) //string, string
        {
            _fname = firstname;
            _lname = lastname;
        }

        public HumanBeings(string name, int age) //string, int
        {
        }

        public HumanBeings(int age, string name) //int, string
        {
        }

        //2. Variables
        private string _fname;

        private string _lname = "Nepal";
        private int age;

        //3. Properties
        public string FirstName { get; set; } = "Babu";

        private string first_name;

        public string First_Name {
            get {
                return first_name;
            }
            set {
                first_name = value;
            }
        }

        //4. Methods / Functions / Actions
        //5. Destructor //not usable
        //6. Events / Delegates
    }
}