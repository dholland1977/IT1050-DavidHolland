using System;

namespace SeasonArray
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] Seasons = { "Winter", "Spring", "Summer", "Fall" };
            int position = 0;

            while (position < Seasons.Length)
            {
                Console.WriteLine(Seasons[position]);
                position = position + 1;
            }
            Console.Read();
        }

        
    }
}
