using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            // torta razmer = ?
            // x , y

            int x = int.Parse(Console.ReadLine()); // 2
            int y = int.Parse(Console.ReadLine()); // 4

            int rest = 0;
            int act = 0;
            int pieces = x * y / (1 * 1);

            while (pieces >= 0)
            {                
                string text = Console.ReadLine(); // 20, 20
                if (text == "STOP")
                {
                    Console.WriteLine($"{rest} pieces are left.");
                    break;
                }
                act = int.Parse(text);
                rest = pieces - act;
                if (pieces < act)
                {
                    Console.WriteLine($"No more cake left! You need {act - pieces} pieces more.");
                    break;
                } 
                
                pieces = rest;
            }

        }
    }
}
