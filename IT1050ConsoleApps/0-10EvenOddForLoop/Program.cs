﻿using System;

namespace _0_10EvenOddForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine($"{i} is even.");
                }
                else
                {
                    Console.WriteLine($"{i} is odd.");
                }
            }
            Console.Read();
        }
    }
}
