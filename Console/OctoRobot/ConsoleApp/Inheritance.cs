namespace Octo.Robot
{
    public class LivingThings
    {
        public int PublicProperty { get; set; }
        private int _privateProperty { get; set; }
        protected int protectedProperty { get; set; }

        public LivingThings()
        {
        }

        public LivingThings(int i)
        {
        }

        public virtual void Eat()
        {
            System.Console.WriteLine("We can eat");
        }

        public void Test()
        {
            System.Console.WriteLine("I am from living thing class");
            //Test();
        }

        public override string ToString()
        {
            return "Hello this is living thing object and I have values for living things";
        }
    }

    //A class can inherit only one class
    public class Animal : LivingThings
    {
        public Animal() : base()
        {
        }

        public Animal(int i) : base(i)
        {
        }

        public int AnimalProperty { get; set; }

        public void Test()
        {
            System.Console.WriteLine("I am from animal class");
        }

        public override void Eat()
        {
            System.Console.WriteLine("We eat raw");
        }
    }

    public class Plants : LivingThings
    {
        public Plants() : base(1)
        {
        }

        public void Eat()
        {
            System.Console.WriteLine("We can do photosynthesis");
        }
    }

    public class Vertibrates : Animal
    {
        public Vertibrates() : base(12)
        {
        }

        public Vertibrates(int i) : base(i)
        {
        }

        public void Test()
        {
            System.Console.WriteLine("I am from vertibrate class");
        }
    }

    //sealed blocks further inheritance
    public sealed class Human : Vertibrates
    {
        public void Test()
        {
            protectedProperty = 20;
        }

        public override void Eat()
        {
            System.Console.WriteLine("we can cook and eat");
        }
    }

    //public class Man : Human
    //{
    //}

    public class Invertibrates : Animal
    {
        public Invertibrates()
        {
        }

        public void Test()
        {
        }

        public void FunctionOne()
        {
            base.Test();
        }
    }
}