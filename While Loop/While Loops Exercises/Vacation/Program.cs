using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Пари нужни за екскурзията -реално число в интервала[1.00...25000.00]
            //•	Налични пари -реално число в интервала[0.00...25000.00]

            //След това многократно се четат по два реда:
            //•	Вид действие – текст с възможности "spend" и "save"
            //•	Сумата, която ще спести / похарчи - реално число в интервала[0.01… 25000.00]

            double vacationPrice = double.Parse(Console.ReadLine());
            double stock = double.Parse(Console.ReadLine());

            int days = 0;

            int dayAfterDay = 0;

            while (stock <= vacationPrice)
            {
                days++;
                string act = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());
                if (act == "spend")
                {
                    if (stock > sum)
                    {
                        stock -= sum;
                        dayAfterDay++;
                    }
                    else
                    {
                        stock = 0;
                        dayAfterDay++;
                    }
                    if (dayAfterDay == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(days);
                        break;
                    }
                }
                else
                {
                    dayAfterDay = 0;
                    stock += sum;
                }
                if (stock >= vacationPrice)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    break;
                }

            }

        }
    }
}
