using System;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 5

            int sum = 0;
            int maxNum = int.MinValue; 

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine()); // 200// 399
                sum += num;               
                if (num > maxNum) // 99 > 200
                {
                    maxNum = num;
                }
            }
            sum -= maxNum;
            if (sum == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(maxNum - sum));
            }
        }
    }
}
