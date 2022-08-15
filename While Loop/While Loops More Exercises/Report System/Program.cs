using System;

namespace Report_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSum = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            double counter = 0;
            double counterCash = 0;
            double counterCard = 0;
            double cash = 0;
            double card = 0;
            double charity = 0;

            while (command != "End")
            {
                counter++;
                int act = int.Parse(command);
                if (counter % 2 != 0)
                {
                    if (act > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        counterCash++;
                        cash += act;
                        Console.WriteLine("Product sold!");
                    }
                }
                else
                {
                    if (act < 10)
                    {
                        Console.WriteLine($"Error in transaction!");
                    }
                    else
                    {
                        counterCard++;
                        card += act;
                        Console.WriteLine("Product sold!");
                    }
                }
                charity = cash + card * 1.00;
                if (charity >= totalSum)
                {
                    Console.WriteLine($"Average CS: {(cash / counterCash):f2}");
                    Console.WriteLine($"Average CC: {(card / counterCard):f2}");
                    return;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Failed to collect required money for charity.");
        }
    }
}
