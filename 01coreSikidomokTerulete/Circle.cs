using System;

namespace _01coreSikidomokTerulete
{
    public class Circle : IPlane
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public int Area()
        {
            return (int) Math.PI * radius * radius;
        }
    }
}