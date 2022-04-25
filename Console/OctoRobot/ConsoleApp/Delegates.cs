namespace Octo.Robot
{
    public class Delegates
    {
        public delegate void MathOps(int a, int b);

        public event MathOps OnMathOps;

        public MathOps math;

        public Delegates()
        {
            OnMathOps += Delegates_OnMathOps;
        }

        private void Delegates_OnMathOps(int a, int b)
        {
            System.Console.WriteLine("From internal function");
            System.Console.WriteLine(a + b);
        }

        public void MathOpsEvent(int a, int b)
        {
            OnMathOps.Invoke(a, b);
        }

        public void DelegateImplementation()
        {
            //math(20, 5);

            MathOps m;
            m = Add;
            m('C', 5);
            m = Subtract;
            m(10, 5);
            m = Multiply;
            m(10, 5);
            m = Divide;
            m = (int a, int b) => {
                System.Console.WriteLine("From anonymous function");
                System.Console.WriteLine(a % b);
            };
            m(10, 5);
        }

        public void MulticastImplementation()
        {
            MathOps m = Add;
            m(10, 5);
            m = m + Subtract;
            m(10, 5);
            m += Multiply;
            m(10, 5);
            m += Divide;
            m(10, 5);
            m -= Multiply;
            m -= Subtract;
            m -= Subtract;
            m(10, 5);
        }

        public void Add(int x, int y)
        {
            System.Console.WriteLine($"Sum is {x + y}");
        }

        public void Subtract(int a, int b)
        {
            System.Console.WriteLine($"Difference is {a - b}");
        }

        public void Multiply(int a, int b)
        {
            System.Console.WriteLine($"Product is {a * b}");
        }

        public void Divide(int a, int b)
        {
            System.Console.WriteLine($"Quotient is {a / b}");
        }
    }

    public class DelegateV2
    {
        public delegate int MathOps(int a, int b);

        public void Implementation()
        {
            MathOps m = Add;
            var res = m(10, 5);
            System.Console.WriteLine(res);

            m = Subtract;
            res = m(10, 5);
            System.Console.WriteLine(res);

            m += Multiply;
            m += Divide;
            res = m(10, 5);
            System.Console.WriteLine(res);
        }

        private int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }
    }
}