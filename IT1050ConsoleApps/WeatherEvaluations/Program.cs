using System;

namespace WeatherEvaluations
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            int temperature = 0;
            string temperatureDescription;
            while (loop)
            {
                Console.WriteLine("Please enter a temperature:");
                try
                {
                    temperature = Convert.ToInt32(Console.ReadLine());
                    loop = false;
                }
                catch
                {
                    Console.WriteLine("That was an invalid temperature, please try again.");
                }
            }
            if (temperature < 32)
            {
                temperatureDescription = "freezing";
            }
            else if (temperature < 50 && temperature > 32)
            {
                temperatureDescription = "cold";
            }
            else if (temperature < 70 && temperature > 50)
            {
                temperatureDescription = "mild";
            }
            else if (temperature < 90 && temperature > 70)
            {
                temperatureDescription = "warm";
            }
            else
            {
                temperatureDescription = "hot";
            }
            Console.WriteLine($"The temperature is {temperatureDescription}.");
            Console.Read();
        }
    }
}
