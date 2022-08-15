using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;
            string act = Console.ReadLine();

            while (act != "Going home")
            {
                steps += int.Parse(act);

                if (steps >= 10000)
                {
                    break;
                }

                act = Console.ReadLine();
            }
            if (act == "Going home")
            {
                act = Console.ReadLine();
                steps += int.Parse(act);
            }
            if (steps < 10000)
            {
                Console.WriteLine($"{10000 - steps} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{steps - 10000} steps over the goal!");
            }
        }
    }
}