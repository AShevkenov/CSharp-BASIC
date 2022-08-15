using System;

namespace Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Първи ред – Сезон – текст "Spring", "Summer", "Autumn" или "Winter"
            //•	Втори ред –  Километри на месец – реално число в интервала[10.00...20000.00]

            string season = Console.ReadLine();
            double km = double.Parse(Console.ReadLine());

            double salary = 0;

            if (km <= 5000)
            {
                if (season == "Summer")
                {
                    salary = km * 0.9;
                }
                else if (season == "Winter")
                {
                    salary = km * 1.05;
                }
                else
                {
                    salary = km * 0.75;
                }


            }
            else if (km > 5000 && km <= 10000)
            {
                if (season == "Summer")
                {
                    salary = km * 1.10;
                }
                else if (season == "Winter")
                {
                    salary = km * 1.25;
                }
                else
                {
                    salary = km * 0.95;
                }

            }
            else if (km > 10000 & km <= 20000)
            {
                salary = km * 1.45;

            }

            salary = salary * 4;
            salary = salary - (salary * 0.1);

            Console.WriteLine($"{salary:f2}");
        }
    }
}

