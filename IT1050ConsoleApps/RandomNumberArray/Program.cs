using System;

namespace RandomNumberArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] RandomNumbers = new int[20];
            Random rnd = new Random();
            
            for (int i = 0; i < RandomNumbers.Length; i++)
            {
                RandomNumbers[i] = rnd.Next(0, 100); //I simplified this instead of setting this to an int and then setting the int to the array position.
            }
            foreach(int number in RandomNumbers)
            {
                Console.WriteLine(number.ToString());
            }
            Console.Read();
        }
    }
}
