using System;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int numbers = 0;
            int Sum = 0;

            while (Sum < firstNumber)
            {
                numbers = int.Parse(Console.ReadLine());
                Sum += numbers;
            }
            Console.WriteLine(Sum);
        }
    }
}
