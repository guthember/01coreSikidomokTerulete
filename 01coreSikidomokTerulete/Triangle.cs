using System;

namespace _01coreSikidomokTerulete
{
    public class Triangle
    {
        private int trianglebase;
        private int height;

        public Triangle(int trianglebase, int height)
        {
            this.trianglebase = trianglebase;
            this.height = height;
        }

        public int  Area()
        {
            return trianglebase * height / 2;
        }
    }
}