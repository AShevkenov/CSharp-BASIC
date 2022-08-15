using System;

namespace Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 3
            string input = Console.ReadLine(); // While

            double presentationEvaluation = 0;
            double averageEvaluation = 0;
            int counterPresentation = 0;
            double evaluationTotal = 0;
            double averageTotal = 0;

            while (input != "Finish")
            {
                string lastProblem = "";
                lastProblem = input;
                input = Console.ReadLine(); //6 

                for (int i = 1; i <= n; i++)
                {
                    presentationEvaluation = double.Parse(input);
                    averageEvaluation += presentationEvaluation;// 6+4
                    evaluationTotal += presentationEvaluation; // 6+4
                    input = Console.ReadLine();
                    
                }
                averageEvaluation = averageEvaluation / n;
                Console.WriteLine($"{lastProblem} - {averageEvaluation:f2}.");

                counterPresentation++;
                averageTotal += averageEvaluation;
                averageEvaluation = 0;
            }

            Console.WriteLine($"Student's final assessment is {(averageTotal / counterPresentation):f2}.");
        }
    }
}
