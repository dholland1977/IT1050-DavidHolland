using System;

namespace _0_30WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int output = 0;
            while(output <= 30)
            {
                Console.WriteLine(output);
                output = output + 3;
            }
            Console.Read();
        }
    }
}
