using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {

            double sum = 100*double.Parse(Console.ReadLine()); // 1.23
            int coins = 0;

            while (sum > 0)
            {
                if (sum >= 200)
                {
                    sum -= 200;
                    coins++;
                }
                else if (sum >= 100 )
                {
                    sum -= 100;
                    coins++;
                }
                else if (sum >= 50)
                {
                    sum -= 50;
                    coins++;
                }
                else if (sum >= 20)
                {
                    sum -= 20;
                    coins++;
                }
                else if (sum >= 10)
                {
                    sum -= 10;
                    coins++;
                }
                else if (sum >= 5)
                {
                    sum -= 5;
                    coins++;
                }
                else if (sum >= 2)
                {
                    sum -= 2;
                    coins++;
                }
                else if (sum >= 1)
                {
                    sum -= 1;
                    coins++;
                }
                else
                    sum = 0;
            }
            Console.WriteLine(coins);


        }
    }
}
