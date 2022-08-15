using System;

namespace Godzilla_vs_Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            //Бюджет за филма – реално число в интервала[1.00 … 1000000.00]
            //Брой на статистите – цяло число в интервала[1 … 500]
            //Цена за облекло на един статист – реално число в интервала[1.00 … 1000.00]

            double budget = double.Parse(Console.ReadLine());
            int extra = int.Parse(Console.ReadLine());
            double outfit = double.Parse(Console.ReadLine());


            //Декорът за филма е на стойност 10 % от бюджета.
            //При повече от 150 статиста,  има отстъпка за облеклото на стойност 10 %.

            double decor = budget * 0.1;
            double outfitTotal = extra * outfit;

            if (extra > 150)
            {
                outfitTotal = outfitTotal - (outfitTotal * 0.1);
            }
            if (budget < decor + outfitTotal)
            {
                budget = budget - decor - outfitTotal;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(budget):f2} leva more.");
            }
            else
            {
                budget = budget - decor - outfitTotal;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget:f2} leva left.");
            }
            //На конзолата трябва да се отпечатат два реда:
            //Ако парите за декора и дрехите са повече от бюджета:
            //o   "Not enough money!"
            //o   "Wingard needs {парите недостигащи за филма} leva more."
            //•	Ако парите за декора и дрехите са по малко или равни на бюджета:
            //o   "Action!"
            //o   "Wingard starts filming with {останалите пари} leva left."
            // :f2




        }
    }
}
