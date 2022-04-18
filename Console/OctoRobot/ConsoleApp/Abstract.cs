using System;
using System.Diagnostics;

namespace Octo.Robot
{
    //abstract class
    public abstract class ShapeAbs
    {
        protected double area { get; set; }
        protected double perimeter { get; set; }
        protected string shapeName { get; set; }

        public void Area()
        {
            System.Console.WriteLine($"Area of {shapeName} is {area}");
        }

        public void Perimeter()
        {
            System.Console.WriteLine($"Perimeter of {shapeName} is {perimeter}");
        }

        public void GetInputAndCalculate()
        {
            GetInput();
            Calculate();
            _addLog();
        }

        private void _addLog()
        {
            Debug.WriteLine($"{shapeName} => Area ={area} Perimeter ={perimeter}");
        }

        protected abstract void Calculate();

        protected abstract void GetInput();
    }

    public class SquareAbs : ShapeAbs
    {
        private double length { get; set; }

        public SquareAbs()
        {
            this.shapeName = "Square";
        }

        protected override void GetInput()
        {
            System.Console.WriteLine("Enter the Length");
            length = Convert.ToDouble(Console.ReadLine());
        }

        protected override void Calculate()
        {
            area = System.Math.Pow(length, 2);
            perimeter = 4 * length;
        }
    }

    public class RectangleAbs : ShapeAbs
    {
        private double length { get; set; }
        private double breadth { get; set; }

        public RectangleAbs()
        {
            shapeName = "Rectangle";
        }

        protected override void GetInput()
        {
            Console.WriteLine("Enter the Length");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Beadth");
            breadth = Convert.ToDouble(Console.ReadLine());
        }

        protected override void Calculate()
        {
            area = length * breadth;
            perimeter = 2 * (length + breadth);
        }
    }

    public class CircleAbs : ShapeAbs
    {
        private double radius { get; set; }

        public CircleAbs()
        {
            shapeName = "Circle";
        }

        protected override void GetInput()
        {
            Console.WriteLine("Enter the radius");
            radius = Convert.ToDouble(Console.ReadLine());
        }

        protected override void Calculate()
        {
            area = System.Math.PI * System.Math.Pow(radius, 2);
            perimeter = 2 * System.Math.PI * radius;
        }
    }
}