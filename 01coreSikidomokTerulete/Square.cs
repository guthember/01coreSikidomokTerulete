using System;

namespace _01coreSikidomokTerulete
{
    public class Square : IPlane
    {
        private int side;

        public Square(int side)
        {
            this.side = side;
        }

        public int Area() 
        {
            return side * side;
        }
    }
}