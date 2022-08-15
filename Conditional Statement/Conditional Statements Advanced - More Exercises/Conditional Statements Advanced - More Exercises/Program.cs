using System;

namespace Conditional_Statements_Advanced___More_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int ppl = int.Parse(Console.ReadLine());
            double tickets = 0;
            double transport = 0;
            double total = 0;


            if (category == "Normal")
            {
                tickets = ppl * 249.99;
            }
            else
            {
                tickets = ppl * 499.99;
            }

            if (ppl >= 50)
            {
                transport = (budget * 0.25);
            }
            else if (ppl >= 25 && ppl <= 49)
            {
                transport = (budget * 0.4);
            }
            else if (ppl >= 10 && ppl <= 24)
            {
                transport = (budget * 0.5);
            }
            else if (ppl >= 5 && ppl <= 9)
            {
                transport = (budget * 0.6);
            }
            else if (ppl >= 1 && ppl <= 4)
            {
                transport = budget * 0.75;
            }
            total = tickets + transport;
            double rest = 0;
            rest = budget - total;
            if (budget >= total)
            {
                Console.WriteLine($"Yes! You have {rest:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(rest):f2} leva.");
            }



        }
    }
}
