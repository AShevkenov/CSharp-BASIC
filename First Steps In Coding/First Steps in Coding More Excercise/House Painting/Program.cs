using System;

namespace House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine()); // 6
            double y = double.Parse(Console.ReadLine()); // 10
            double h = double.Parse(Console.ReadLine()); // 5.2

            double frontRearSide = (x * x) * 2;
            double frontReadWithoutDoor = frontRearSide - (1.2 * 2);

            double leftRightSide = x * y;
            double leftRightWithoutWindows = (2 * leftRightSide) - ((1.5 * 1.5) * 2);

            double totalAreaHouse = leftRightWithoutWindows + frontReadWithoutDoor;
            double totalPaintHouse = totalAreaHouse / 3.4;

            double frontRearRoof = (x * h / 2) * 2;
            double leftRightRoof = (x * y) * 2;

            double totalAreaRoof = frontRearRoof + leftRightRoof;
            double totalPaintRoof = totalAreaRoof / 4.3;

            Console.WriteLine($"{totalPaintHouse:f2}");
            Console.WriteLine($"{totalPaintRoof:f2}");


        }
    }
}
