using System;

namespace For_Loops_More_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Наследените пари – реално число в интервала[1.00... 1 000 000.00]
            //•	Годината, до която трябва да живее(включително) – цяло число в интервала[1801... 1900]

            double inheritance = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());
            double costs = 0;
            int age = 0;

            for (int i = 1800; i <= yearToLive ; i++)
            {
                age = yearToLive - 1800 + 18;

                if (i % 2 == 0)
                {
                    costs += 12000;                   
                }               
            }
            for (int n = 18; n <= age; n++)
            {
                if (n % 2 == 1)
                {
                    costs += 12000 + (50 * n);
                }
            }
            if (costs > inheritance)
                Console.WriteLine($"He will need {costs - inheritance:f2} dollars to survive.");
            else
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritance - costs:f2} dollars left.");
            }
        }
    }
}
