using System;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Рекордът в секунди – реално число в интервала[0.00 … 100000.00]
            //2.Разстоянието в метри – реално число в интервала[0.00 … 100000.00]
            //3.Времето в секунди, за което плува разстояние от 1 м. - реално число в интервала[0.00 … 1000.00]

            double worldRecord = double.Parse(Console.ReadLine()); // 10464
            double meters = double.Parse(Console.ReadLine()); // 1500
            double timeInSecondsPerMeter = double.Parse(Console.ReadLine()); // 20


            double lagging = (Math.Floor(meters / 15) * 12.5);
            double IvanTime = Math.Round(meters * timeInSecondsPerMeter + lagging, 2);

            //          	Ако Иван е подобрил Световния рекорд(времето му е по-малко от рекорда) отпечатваме:
            // " Yes, he succeeded! The new world record is {времето на Иван} seconds."
            //              Ако НЕ е подобрил рекорда(времето му е по - голямо или равно на рекорда) отпечатваме:
            //  "No, he failed! He was {недостигащите секунди} seconds slower."
            //Резултатът трябва да се форматира до втория знак след десетичната запетая.

            if (IvanTime < worldRecord)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {IvanTime:f2} seconds.");
            }
            else
            {
                double rest = worldRecord - IvanTime;
                Console.WriteLine($"No, he failed! He was {Math.Abs(rest):f2} seconds slower.");
            }

        }
    }
}
