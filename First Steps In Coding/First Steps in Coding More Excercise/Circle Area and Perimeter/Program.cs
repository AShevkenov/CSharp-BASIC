﻿using System;

namespace Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double calculatedArea = Math.PI * (r * r);
            double calculatePerimeter = 2 * Math.PI * r;

            Console.WriteLine($"{calculatedArea:f2}");
            Console.WriteLine($"{calculatePerimeter:f2}");

        }
    }
}
