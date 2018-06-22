using System;

namespace ForEachArrayOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}
