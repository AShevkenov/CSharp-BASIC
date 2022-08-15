using System;

namespace Sequences_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 8
            int numbers = 1;

            while (numbers <= n)
            {
                Console.WriteLine(numbers);
                numbers = numbers * 2 + 1; // 1 , 3 ,7
            }
        }
    }
}
