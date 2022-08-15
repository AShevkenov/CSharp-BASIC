using System;

namespace Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            //T(°F) = T(°C) × 9/5 + 32
            double fahr = (celsius * (9 / 5.00)) + 32;

            Console.WriteLine($"{fahr:f2}");

        }
    }
}
