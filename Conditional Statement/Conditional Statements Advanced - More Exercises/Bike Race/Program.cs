using System;

namespace Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Първият ред – броят младши велосипедисти.Цяло число в интервала[1…100]
            //•	Вторият ред – броят старши велосипедисти.Цяло число в интервала[1… 100]
            //•	Третият ред – вид трасе – "trail", "cross-country", "downhill" или "road"


            int juniors = int.Parse(Console.ReadLine()); // 30
            int seniors = int.Parse(Console.ReadLine()); // 25
            string trace = Console.ReadLine(); // cross-country

            double juniorTax = 0;
            double seniorTax = 0;
            double discount = 0;
            double charity = 0;
            if (trace == "trail")
            {
                juniorTax = juniors * 5.50;
                seniorTax = seniors * 7;

            }
            else if (trace == "cross-country")
            {
                juniorTax = juniors * 8;
                seniorTax = seniors * 9.50;
            }
            else if (trace == "downhill")
            {
                juniorTax = juniors * 12.25;
                seniorTax = seniors * 13.75;
            }
            else
            {
                juniorTax = juniors * 20;
                seniorTax = seniors * 21.50;
            }
            int players = juniors + seniors;
            double taxes = juniorTax + seniorTax;

            if (players >= 50 && trace == "cross-country")
            {
                discount = taxes * 0.25;
                taxes = taxes - discount;
                double bills = taxes * 0.05;
                charity = taxes - bills;
                Console.WriteLine($"{charity:f2}");

            }
            else
            {
                charity = juniorTax + seniorTax - (juniorTax * 0.05 + seniorTax * 0.05);
                Console.WriteLine($"{charity:f2}");
            }

        }
    }
}
