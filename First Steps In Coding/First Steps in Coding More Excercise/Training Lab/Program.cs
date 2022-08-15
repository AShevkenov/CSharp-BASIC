using System;

namespace Training_Lab
{
    class Program
    {

        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double workStations1 = h - (100 / 100);
            workStations1 = Math.Floor(workStations1 / 0.7);

            double workStations2 = Math.Floor(w / 1.2);

            double workStationsAtAll = workStations1 * workStations2 - 3;

            Console.WriteLine(workStationsAtAll);


        }
    }
}
