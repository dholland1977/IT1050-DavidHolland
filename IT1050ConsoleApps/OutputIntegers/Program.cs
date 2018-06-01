using System;

namespace OutputIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 2;
            int z = 5;

            Console.WriteLine("The solution to (10 + 2) * (5 + 10) is {0}", (x + y) * (z + 10));
            Console.Read();

        }
    }
}