using System;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            double account = 0;

            while (input != "NoMoreMoney")
            {
                double ammount = double.Parse(input);
                if (ammount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                account += ammount;
                Console.WriteLine($"Increase: {ammount:f2}");

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {account:f2}");

        }
    }
}
