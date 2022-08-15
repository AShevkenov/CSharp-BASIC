using System;

namespace Rent_a_car
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Първи ред – Бюджет – реално число в интервала[10.00...10000.00]
            //•	Втори ред –  Сезон – текст "Summer" или "Winter"

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string typeCar = "";
            string classType = "";
            double rent = 0;
            if (budget <= 100 && season == "Summer")
            {
                rent = budget * 0.35;
                classType = "Economy class";
                typeCar = "Cabrio";

            }
            else if (budget <= 100 && season == "Winter")
            {
                rent = budget * 0.65;
                classType = "Economy class";
                typeCar = "Jeep";
            }
            else if (budget > 100 && budget <= 500 && season == "Summer")
            {
                rent = budget * 0.45;
                classType = "Compact class";
                typeCar = "Cabrio";
            }
            else if (budget > 100 && budget <= 500 && season == "Winter")
            {
                rent = budget * 0.8;
                classType = "Compact class";
                typeCar = "Jeep";
            }
            else if (budget > 500)
            {
                rent = budget * 0.9;
                classType = "Luxury class";
                typeCar = "Jeep";
            }

            Console.WriteLine($"{classType}");
            Console.WriteLine($"{typeCar} - {rent:f2}");
        }
    }
}
