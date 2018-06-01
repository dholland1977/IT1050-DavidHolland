using System;

namespace EscapeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hello World!
            Console.WriteLine("Hello\tWorld!");
            //Hello
            //World
            Console.WriteLine("Hello\nWorld");
            //Hello World!
            Console.WriteLine("\"Hello World!\"");
            //Hello\World!
            Console.WriteLine("Hello\\World!");
            Console.Read();
        }
    }
}
