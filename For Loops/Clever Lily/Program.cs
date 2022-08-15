using System;

namespace For_Loops_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Възрастта на Лили - цяло число в интервала[1...77]
            //•	Цената на пералнята - число в интервала[1.00...10 000.00]
            //•	Единична цена на играчка -цяло число в интервала[0...40]

            int age = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            double money = 0;
            double birthdays = 0;
            double total = 0;
            int toys = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    birthdays++;
                    money = money + 10;
                    total += money;
                }
                else
                {
                    toys++;
                }
            }
            toyPrice = toyPrice * toys;
            total = total + toyPrice - birthdays;

            if (total >= washingMachine)
            {
                Console.WriteLine($"Yes! {total - washingMachine:f2}");
            }
            else
                Console.WriteLine($"No! {washingMachine - total:f2}");
        }
    }
}
