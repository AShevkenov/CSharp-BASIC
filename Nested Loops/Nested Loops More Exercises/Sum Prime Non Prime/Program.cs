using System;

namespace Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = (Console.ReadLine());

            double num = 0;
            double primeNumbers = 0;
            double nonPrimeNumbers = 0;

            while (input != "stop")
            {
                num = int.Parse(input);

                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                // Просто число: числото > 1; да се дели единствено на 1 и на себе си:           (num % 1 == 0) && (num & num == 0)
                bool isPrime = true;

                for (int i = 2; i < num - 1; i++) 
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeNumbers += num;
                }
                else
                {
                    nonPrimeNumbers += num;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeNumbers}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNumbers}");
        }
    }
}
