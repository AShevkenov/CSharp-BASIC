using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //групи на числа според това в кой интервал се намират
            double p1 = 0; // броя на числата в интервал от (0 - 199)
            double p2 = 0;// броя на числата в интервал от (200 - 399)
            double p3 = 0;// броя на числата в интервал от (400 - 599)
            double p4 = 0;// броя на числата в интервал от (600 - 799)
            double p5 = 0;// броя на числата в интервал от (800 - 1000)

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num <= 199)
                {
                    // p1 += 1;
                    // p1 = p1 + 1;
                    p1++;
                }
                else if (num <= 399)
                {
                    p2++;
                }
                else if (num <= 599)
                {
                    p3++;
                }
                else if (num <= 799)
                {
                    p4++;
                }
                else if (num <= 1000)
                {
                    p5++;
                }

            }
            p1 = p1 / n * 100;
            p2 = p2 / n * 100;
            p3 = p3 / n * 100;
            p4 = p4 / n * 100;
            p5 = p5 / n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
