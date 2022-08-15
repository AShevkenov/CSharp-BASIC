using System;

namespace Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegKiloPrice = double.Parse(Console.ReadLine());
            double fruitKiloPrice = double.Parse(Console.ReadLine());
            int vegKiloTotal = int.Parse(Console.ReadLine());
            int fruitKiloTotal = int.Parse(Console.ReadLine());

            double vegInEuro = vegKiloPrice * vegKiloTotal / 1.94;
            double fruitInEuro = fruitKiloPrice * fruitKiloTotal / 1.94;

            double total = vegInEuro + fruitInEuro;


            Console.WriteLine($"{total:f2}");

        }
    }
}
