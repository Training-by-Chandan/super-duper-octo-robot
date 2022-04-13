using System;

namespace Octo.Robot
{
    public interface IArea
    {
        void Area();
    }

    public interface IPerimeter
    {
        void Perimeter();
    }

    public interface IShape : IArea, IPerimeter
    {
        void GetInput();
    }

    public class Square : IShape
    {
        public double Length { get; set; }

        public void Area()
        {
            var area = System.Math.Pow(Length, 2);
            Console.WriteLine($"Area of square = {area}");
        }

        public void GetInput()
        {
            System.Console.WriteLine("Enter the Length");
            Length = Convert.ToDouble(Console.ReadLine());
        }

        public void Perimeter()
        {
            var perimeter = 4 * Length;
            Console.WriteLine($"Perimeter of square = {perimeter}");
        }
    }

    public class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public void Area()
        {
            var area = Length * Breadth;
            Console.WriteLine($"Area of rectangle = {area}");
        }

        public void GetInput()
        {
            System.Console.WriteLine("Enter the Length");
            Length = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Enter the Breadth");
            Breadth = Convert.ToDouble(Console.ReadLine());
        }

        public void Perimeter()
        {
            var perimeter = 2 * (Length + Breadth);
            Console.WriteLine($"Perimeter of rectangle = {perimeter}");
        }
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }

        public void Area()
        {
            var area = System.Math.PI * System.Math.Pow(Radius, 2);
            Console.WriteLine($"Area of Circle = {area}");
        }

        public void GetInput()
        {
            System.Console.WriteLine("Enter the Radius");
            Radius = Convert.ToDouble(Console.ReadLine());
        }

        public void Perimeter()
        {
            var periemter = 2 * System.Math.PI * Radius;
            Console.WriteLine($"Circumference of circle = {periemter}");
        }
    }

    public class Triangle : IShape
    {
        public void Area()
        {
            throw new NotImplementedException();
        }

        public void GetInput()
        {
            throw new NotImplementedException();
        }

        public void Perimeter()
        {
            throw new NotImplementedException();
        }
    }
}