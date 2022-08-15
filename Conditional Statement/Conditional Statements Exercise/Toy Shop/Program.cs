using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.Цена на екскурзията -реално число в интервала[1.00 … 10000.00]
            //2.Брой пъзели - цяло число в интервала[0… 1000]
            //3.Брой говорещи кукли -цяло число в интервала[0 … 1000]
            //4.Брой плюшени мечета -цяло число в интервала[0 … 1000]
            //5.Брой миньони - цяло число в интервала[0 … 1000]
            //6.Брой камиончета - цяло число в интервала[0 … 1000]
            double excursionPrice = double.Parse(Console.ReadLine());
            int amountOfPuzzels = int.Parse(Console.ReadLine());
            int amountOfTalkingToys = int.Parse(Console.ReadLine());
            int amountOfGummyBears = int.Parse(Console.ReadLine());
            int amountOfMinions = int.Parse(Console.ReadLine());
            int amountOfTrucks = int.Parse(Console.ReadLine());

            
            double rest = 0;
            // Пъзел - 2.60 лв.
            // Говореща кукла -3 лв.
            // Плюшено мече -4.10 лв.
            // Миньон - 8.20 лв.
            // Камионче - 2 лв.

            double puzzlePrice = 2.60 * amountOfPuzzels;
            double talkingToyPrice = 3 * amountOfTalkingToys;
            double gummyBearsPrice = 4.10 * amountOfGummyBears;
            double minionPrice = 8.20 * amountOfMinions;
            double truckPrice = 2 * amountOfTrucks;

            double totalPrice = puzzlePrice + talkingToyPrice + gummyBearsPrice + minionPrice + truckPrice;

            double totalAmount = amountOfPuzzels + amountOfTalkingToys + amountOfGummyBears + amountOfMinions + amountOfTrucks;

            if (totalAmount >= 50)
            {

                totalPrice = totalPrice - (totalPrice * 0.25);
                totalPrice = totalPrice - (totalPrice * 0.1);

            }
            else
            {
                totalPrice = totalPrice - (totalPrice * 0.1);
            }

            if (totalPrice >= excursionPrice)
            {
                rest = totalPrice - excursionPrice;
                Console.WriteLine($"Yes! {rest:f2} lv left.");
            }
            else
            {
                rest = excursionPrice - totalPrice;
                Console.WriteLine($"Not enough money! {rest:f2} lv needed.");
            }



        }
    }
}
