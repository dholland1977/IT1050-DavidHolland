using System;

namespace SumOfTwoInputs
{
    static class Program
    {
        static void Main(string[] args)
        {
            bool mainLoop = true;
            while (mainLoop == true)
            {
                int input1 = 0;
                int input2 = 0;
                bool intLoop1 = true;
                bool intLoop2 = true;
                while (intLoop1)
                {
                    Console.WriteLine("Please enter first integer:");
                    try
                    {
                        input1 = Convert.ToInt32(Console.ReadLine());
                        intLoop1 = false;
                    }
                    catch
                    {
                        Console.WriteLine("That was an invalid int, please try again.");
                    }
                }
                while (intLoop2)
                {
                    Console.WriteLine("Please enter second integer:");
                    try
                    {
                        input2 = Convert.ToInt32(Console.ReadLine());
                        intLoop2 = false;
                    }
                    catch
                    {
                        Console.WriteLine("That was an invlid int, please try again.");
                    }
                }
                Console.WriteLine($"Your total is: {AddValues(input1, input2).ToString()}");
                Console.WriteLine("Press any key to add two different values.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static int AddValues(int int1, int int2)
        {
            return int1 + int2;
        }
    }
}
