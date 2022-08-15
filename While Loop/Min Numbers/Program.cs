using System;

namespace Min_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int min = int.MaxValue;
            int newNumbers = 0;

            while (numbers != "Stop")
            {
                newNumbers = int.Parse(numbers);
                if (newNumbers < min)
                {
                    min = newNumbers;
                }
                numbers = Console.ReadLine();
            }
            Console.WriteLine(min);
        }
    }
}
