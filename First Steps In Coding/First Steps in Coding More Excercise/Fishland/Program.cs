using System;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
         
            //Първи ред – цена на скумрията на килограм.Реално число в интервала[0.00…40.00]
            //Втори ред – цена на цацата на килограм.Реално число в интервала[0.00…30.00]
            //Трети ред – килограма паламуд. Реално число в интервала[0.00…50.00]
            //Четвърти ред – килограма сафрид. Реално число в интервала[0.00… 70.00]
            //Пети ред – килограма миди. Цяло число в интервала[0... 100]

            double mackerelPricePerKilo = double.Parse(Console.ReadLine());
            double toyPricePerKilo = double.Parse(Console.ReadLine());
            double bonitoKilo = double.Parse(Console.ReadLine());
            double scadKilo = double.Parse(Console.ReadLine());
            int musselsKilo = int.Parse(Console.ReadLine());

            //Паламуд – 60 % по - скъп от скумрията
            //Сафрид – 80 % по - скъп от цацата
            //Миди – 7.50 лв.за килограм

            double bonitoPricePerKilo = mackerelPricePerKilo + (mackerelPricePerKilo * 0.6);
            double scadPricePerKilo = toyPricePerKilo + (toyPricePerKilo * 0.8);
            double musselsPrice = musselsKilo * 7.50;

            double bonitoPrice = (bonitoPricePerKilo * bonitoKilo);
            double scadPrice = scadKilo * scadPricePerKilo;

            //Да се отпечата на конзолата едно число с плаваща запетая: колко пари ще са нужни на Георги, за да си плати сметката. Числото трябва да е форматирано до вторият знак след десетичната запетая (1.2457 -> 1.25).

            double total = bonitoPrice + scadPrice + musselsPrice;

            Console.WriteLine($"{total:f2}");

        }
    }
}
