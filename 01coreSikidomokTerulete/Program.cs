using System;

namespace _01coreSikidomokTerulete
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(side: 4);
            Console.WriteLine($"A square area: {square.Area()}");

            var circle = new Circle(radius: 5);
            Console.WriteLine($"A cirlce area: {circle.Area()}");

            var triangle = new Triangle(trianglebase: 6, height: 4);
            Console.WriteLine($"A triangle area: {triangle.Area()}");

            Console.ReadLine();
        }
    }
}
