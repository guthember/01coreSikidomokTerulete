using System;
using System.Collections.Generic;
using System.Linq;

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

            // területek összeadása

            var areasum = square.Area();

            areasum += circle.Area();

            areasum += triangle.Area();

            Console.WriteLine($"The areas: {areasum}");

            var planes = new List<IPlane>();

            planes.Add(square);
            planes.Add(circle);
            planes.Add(triangle);

            //var sum = 0;
            //foreach (var plane in planes)
            //{
            //    sum += plane.Area();
            //}
                       
            //Console.WriteLine($"The areas (new type): {sum}");
            Console.WriteLine($"The areas (new type): {planes.Sum(x => x.Area())}");
            Console.ReadLine();
        }
    }
}
