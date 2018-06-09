using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath math = new MyMath();
            Console.WriteLine(math.Add(9, 19));
            Console.WriteLine(math.Factorial(9));
            Console.WriteLine(math.Min(20, 21));
            Console.WriteLine(math.Multiply(19, 2));
            Console.Read();
        }
    }
}
