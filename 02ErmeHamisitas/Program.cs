﻿using System;

namespace _02ErmeHamisitas
{
    class Program
    {
        static void Main(string[] args)
        {
            var coin = new Coin();

            Console.WriteLine("Az érmefeldobások eredménye:");
            for (int i = 0; i < 100; i++)
            {
                Console.Write($"{coin.Toss()},");
            }
        }
    }
}
