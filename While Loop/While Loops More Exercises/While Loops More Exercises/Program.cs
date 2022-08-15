using System;

namespace While_Loops_More_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            int bottles = int.Parse(Console.ReadLine());
            int totalDetergent = 750 * bottles;
            int detergentForOneDish = 5;
            int detergentForOnePot = 15;

            int quantity = 0;
            int quantityDish = 0;
            int quantityPot = 0;
            int counter = 0;

            while (totalDetergent >= 0)
            {
                counter++;
                string act = Console.ReadLine();
                if (act == "End")
                {

                    Console.WriteLine($"Detergent was enough!");
                    Console.WriteLine($"{quantityDish} dishes and {quantityPot} pots were washed.");
                    Console.WriteLine($"Leftover detergent {totalDetergent} ml.");
                    break;
                }

                quantity = int.Parse(act);

                if (counter == 3)
                {
                    totalDetergent -= detergentForOnePot * quantity;
                    quantityPot += quantity;
                    counter = 0;

                }
                else
                {
                    totalDetergent -= detergentForOneDish * quantity;
                    quantityDish += quantity;
                }

                if (totalDetergent < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(totalDetergent)} ml. more necessary!");
                    break ;
                }
            }

        }
    }
}
