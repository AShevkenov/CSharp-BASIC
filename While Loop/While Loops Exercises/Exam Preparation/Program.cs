using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());

            string problemsName = Console.ReadLine();          

            double averageGrade = 0;
            int sumGrade = 0;
            int problems = 0;
            int counterBadGrades = 0;
            string lastProblem = String.Empty;

            while (problemsName != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                problems++;
                sumGrade += grade;
                averageGrade = sumGrade * 1.00 / problems;
                if (grade <= 4)
                {
                    counterBadGrades++;
                }
                if (counterBadGrades == badGrades)
                {
                    Console.WriteLine($"You need a break, {counterBadGrades} poor grades.");
                    break;
                }
                lastProblem = problemsName;
                problemsName = Console.ReadLine();
                
               
            }
            if (problemsName == "Enough")
            {
                Console.WriteLine($"Average score: {averageGrade:f2}");
                Console.WriteLine($"Number of problems: {problems}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
