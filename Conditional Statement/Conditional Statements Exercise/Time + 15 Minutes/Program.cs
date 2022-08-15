using System;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());

            int timeInMin = mins + hours * 60;
            timeInMin += 15;

            hours = timeInMin / 60;
            mins = timeInMin % 60;

            if (hours == 24)
            {
                hours = 0;

            }
            if (mins < 10)
            {
                Console.WriteLine($"{hours}:0{mins}");
            }
            else
                Console.WriteLine($"{hours}:{mins}");


        }
    }
}
