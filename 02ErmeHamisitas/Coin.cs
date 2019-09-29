using System;

namespace _02ErmeHamisitas
{
    public class Coin
    {
        Random random = new Random();
        public int Toss()
        {
            return random.Next(0,2);
        }
    }
}