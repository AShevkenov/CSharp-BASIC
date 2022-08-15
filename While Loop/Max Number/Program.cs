using System;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine(); // 100
            int max = int.MinValue;
            int newNumbers = 0;

            while (numbers != "Stop")
            {
                newNumbers = int.Parse(numbers);
                if (newNumbers > max)
                {
                    max = newNumbers;
                }
                numbers = Console.ReadLine();
            }
            Console.WriteLine(max);
        }
    }
}
