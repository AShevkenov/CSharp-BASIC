using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {


            double budget = double.Parse(Console.ReadLine());
            int amountOfVideoCard = int.Parse(Console.ReadLine());
            int amountOfCPU = int.Parse(Console.ReadLine());
            int amountOfRAM = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            int videoCardPrice = amountOfVideoCard * 250;
            double CPUPrice = amountOfCPU * (videoCardPrice * 0.35);
            double RAMPrice = amountOfRAM * (videoCardPrice * 0.10);

            totalPrice = videoCardPrice + CPUPrice + RAMPrice;


            if (amountOfVideoCard > amountOfCPU)
            {
                totalPrice = totalPrice - (totalPrice * 0.15);

            }
            double rest = 0;
            rest = budget - totalPrice;
            if (rest >= 0)
            {
                Console.WriteLine($"You have {rest:f2} leva left!");

            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(rest):f2} leva more!");
            }
        }
    }
}
