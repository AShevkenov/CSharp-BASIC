using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
     
            int freeWidth = int.Parse(Console.ReadLine());
            int freeLength = int.Parse(Console.ReadLine());
            int freeHeight = int.Parse(Console.ReadLine());

            int freeSpace = (freeWidth * freeLength) * freeHeight;
            int occupiedSpace = 0;
            int boxes = 1;


            while (freeSpace >= occupiedSpace)
            {
                string act = Console.ReadLine();
                if (act == "Done")
                {
                    Console.WriteLine($"{freeSpace} Cubic meters left.");
                    break;
                }
                boxes = int.Parse(act);
                if (freeSpace <= boxes)
                {
                    Console.WriteLine($"No more free space! You need {boxes - freeSpace} Cubic meters more.");
                    break;
                }

                freeSpace -= boxes;

            }

        }
    }
}
