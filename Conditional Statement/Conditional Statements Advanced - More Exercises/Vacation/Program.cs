using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Първи ред – Бюджет – реално число в интервала[10.00...10000.00]
            //•	Втори ред –  Сезон – текст "Summer" или "Winter"
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string place = "";
            string loc = "";
            double price = 0;
            if (budget <= 1000 && season == "Summer")
            {
                place = "Camp";
                loc = "Alaska";
                price = budget * 0.65;
            }
            else if (budget <= 1000 && season == "Winter")
            {
                place = "Camp";
                loc = "Morocco";
                price = budget * 0.45;
            }
            else if (budget > 1000 && budget <= 3000 && season == "Summer")
            {
                place = "Hut";
                loc = "Alaska";
                price = budget * 0.8;
            }
            else if (budget > 1000 && budget <= 3000 && season == "Winter")
            {
                place = "Hut";
                loc = "Morocco";
                price = budget * 0.60;
            }
            else if (budget > 3000 && season == "Summer")
            {
                place = "Hotel";
                loc = "Alaska";
                price = budget * 0.9;
            }
            else
            {
                place = "Hotel";
                loc = "Morocco";
                price = budget * 0.9;
            }
            Console.WriteLine($"{loc} - {place} - {price:f2}");

        }
    }
}
