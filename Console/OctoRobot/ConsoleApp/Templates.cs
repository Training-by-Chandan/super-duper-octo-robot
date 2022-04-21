namespace Octo.Robot
{
    public class TemplatedClass<T1, T2, T3>
        where T1 : IShape, ITest
       where T3 : LivingThings
    {
        public TemplatedClass(T1 t1, T2 t2, T3 t3)
        {
            Variable1 = Variable4 = t1;
            Variable2 = Variable5 = t2;
            Variable3 = Variable6 = t3;
        }

        public T1 Variable1 { get; set; }
        public T2 Variable2 { get; set; }
        public T3 Variable3 { get; set; }
        public T1 Variable4 { get; set; }
        public T2 Variable5 { get; set; }
        public T3 Variable6 { get; set; }

        public void DisplayTypes()
        {
            System.Console.WriteLine($"Type of Variable 1 is {Variable1.GetType()}");
            System.Console.WriteLine($"Type of Variable 2 is {Variable2.GetType()}");
            System.Console.WriteLine($"Type of Variable 3 is {Variable3.GetType()}");
            System.Console.WriteLine($"Type of Variable 4 is {Variable4.GetType()}");
            System.Console.WriteLine($"Type of Variable 5 is {Variable5.GetType()}");
            System.Console.WriteLine($"Type of Variable 6 is {Variable6.GetType()}");
        }
    }

    public class Test
    {
        public void Function<T1, T2>(T1 item1, T2 item2)
            where T1 : IShape
            where T2 : LivingThings
        {
            //todo by ourselves
        }
    }
}