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
        //f. mostly public, in some cases public static and in some cases protected
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
        //4. Methods / Functions / Actions
        //5. Destructor //not usable
        //6. Events / Delegates
    }
}