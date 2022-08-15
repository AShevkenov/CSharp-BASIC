using System;

namespace _02._Hospital
{
    class Program
    {
        static void Main(string[] args)
        {

            int cargo = int.Parse(Console.ReadLine());
            int price0to3 = 0;
            int price4to11 = 0;
            int priceOver12 = 0;
            int totalTons = 0;
            int cargo0to3 = 0;
            int cargo4to11 = 0;
            int cargoOver12 = 0;

            for (int i = 0; i < cargo; i++)
            {
                int tons = int.Parse(Console.ReadLine());
                totalTons += tons;
                if (tons <= 3)
                {
                    price0to3 += 200 * tons;
                    cargo0to3 += tons;
                    
                }
                else if (tons <= 11)
                {
                    price4to11 += 175 * tons;
                    cargo4to11 += tons;
                }
                else
                {
                    priceOver12 += 120 * tons;
                    cargoOver12 += tons;
                }
            }
            double average = (price0to3 + price4to11 + priceOver12) / (totalTons*1.00);
            double microbus = (cargo0to3*1.00 / totalTons) * 100.00;
            double truck = (cargo4to11*1.00 / totalTons) * 100.00;
            double train = (cargoOver12*1.00 / totalTons) * 100.00;

            Console.WriteLine($"{average:f2}");
            Console.WriteLine($"{microbus:f2}%");
            Console.WriteLine($"{truck:f2}%");
            Console.WriteLine($"{train:f2}%");
        }
    }
}