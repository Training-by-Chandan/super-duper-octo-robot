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

        public virtual void Test()
        {
            System.Console.WriteLine("I am from living thing class");
            //Test();
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

        public override void Test()
        {
            System.Console.WriteLine("I am from animal class");
        }
    }

    public class Plants : LivingThings
    {
        public Plants() : base(1)
        {
        }
    }

    public class Vertibrates : Animal
    {
        public Vertibrates()
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