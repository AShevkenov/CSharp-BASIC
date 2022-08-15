using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int grade = 1;
            double sum = 0;
            int counter = 0;
            while (grade <= 12)
            {
                double GPA = double.Parse(Console.ReadLine());
                if (GPA < 4)
                {
                    counter++;
                    if (counter == 2)
                    {
                        break;
                    }                
                    continue;
                }
                sum += GPA;
                grade++;
            }
            sum /= 12;
            if (grade > 12)
            Console.WriteLine($"{name} graduated. Average grade: {sum:f2}");
            if (counter == 2)
                Console.WriteLine($"{name} has been excluded at {grade} grade");
        }
    }
}
