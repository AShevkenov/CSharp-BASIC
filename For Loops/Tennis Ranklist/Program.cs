using System;

namespace Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Брой турнири, в които е участвал – цяло число в интервала[1…20] 
            //•	Начален брой точки в ранглистата - цяло число в интервала[1...4000]

            //За всеки турнир се прочита отделен ред:
            //•	Достигнат етап от турнира – текст – "W", "F" или "SF"

            int tournaments = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            int points = 0;
            int winner = 0;

            for (int i = 0; i < tournaments; i++)
            {
                string stage = Console.ReadLine();

                if (stage == "W")
                {
                    winner++;
                    points += 2000;
                }
                else if (stage == "F")
                {
                    points += 1200;
                }
                else if (stage == "SF")
                {
                    points += 720;
                }
            }
            double totalPoints = points + startPoints;
            double averagePointsPerTour = points / tournaments;
            double percentWon = winner*1.00 / tournaments * 100;

            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {Math.Floor(averagePointsPerTour)}");
            Console.WriteLine($"{percentWon:f2}%");
        }
    }
}
