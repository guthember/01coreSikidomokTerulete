using System;

namespace _01coreSikidomokTerulete
{
    public class Square
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