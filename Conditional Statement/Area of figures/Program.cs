using System;

namespace Area_of_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            // На първия ред на входа се чете вида на фигурата (текст със следните възможности: square, rectangle, circle или triangle).
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double area = side * side;
                Console.WriteLine($"{area:f3}");
            }
            else if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double area = sideA * sideB;
                Console.WriteLine($"{area:f3}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Math.PI * (radius * radius);
                Console.WriteLine($"{area:f3}");
            }
            else if (figure == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = (sideA * height) / 2;
                Console.WriteLine($"{area:f3}");
            }
        }
    }
}
