using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double pointsAcademy = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string nameOfJudge = Console.ReadLine();
                double pointsOfJudge = double.Parse(Console.ReadLine());

                pointsAcademy = pointsAcademy + ((nameOfJudge.Length) * pointsOfJudge) / 2;

                if (pointsAcademy >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {pointsAcademy:f1}!");
                    break;
                }

            }
            if (pointsAcademy < 1250.5)
            {

                Console.WriteLine($"Sorry, {name} you need {1250.5 - pointsAcademy:f1} more!");
            }
        }
    }
}
