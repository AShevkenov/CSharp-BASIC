using System;

namespace Sarafovo
{
    class Program
    {
        static void Main(string[] args)
        {
            double block = 1;
            double razstoqnie = 1.20;

            double sideOne = 38.5;

            for (double i = 1.2; i <= 38.5; i += 1.80)
            {
                Console.WriteLine(block++);
            }
        
            Console.WriteLine($"{21 + 3 + 28 + 9 + 21 + 22 + 10}");
        }
    }
}
