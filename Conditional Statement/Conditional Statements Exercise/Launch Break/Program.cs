using System;

namespace Launch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Име на сериал – текст
            //2.Продължителност на епизод – цяло число в диапазона[10… 90]
            //3.Продължителност на почивката – цяло число в диапазона[10… 120]

            string movie = Console.ReadLine(); // GOT
            int durationMovie = int.Parse(Console.ReadLine()); // 60
            int durationBreak = int.Parse(Console.ReadLine()); // 96

            //Времето за обяд ще бъде 1/8 от времето за почивка
            //времето за отдих ще бъде 1/4 от времето за почивка.

            double lunchTime = durationBreak * (1.0 / 8);
            double relaxTime = durationBreak * (1.0 / 4);

            double restTime = durationBreak - lunchTime - relaxTime;

            if (restTime >= durationMovie)
                Console.WriteLine($"You have enough time to watch {movie} and left with {Math.Ceiling(restTime - durationMovie)} minutes free time.");
            else
            {
                Console.WriteLine($"You don't have enough time to watch {movie}, you need {Math.Ceiling(Math.Abs(restTime - durationMovie))} more minutes.");
            }


        }
    }
}
