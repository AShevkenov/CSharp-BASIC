using System;

namespace Number_1_to_10
{
    class Program
    {
        static void Main(string[] args)
        {

            // beer -> Sofia -> 6 (Цената трябва да е 6х1.20 = 7.20; На мен ми отпечатва 7.1999999999

            
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0;
            if (city == "Sofia")
            {
                if (product == "coffee")
                    price = quantity * 0.50;
                else if (product == "water")
                    price = quantity * 0.80;
                else if (product == "beer")
                    price = quantity * 1.20;
                else if (product == "sweets")
                    price = quantity * 1.45;
                else if (product == "peanuts")
                    price = quantity * 1.60;
            }
            else if (city == "Plovdiv")
            {
                if (product == "coffee")
                    price = quantity * 0.40;
                else if (product == "water")
                    price = quantity * 0.70;
                else if (product == "beer")
                    price = quantity * 1.15;
                else if (product == "sweets")
                    price = quantity * 1.30;
                else if (product == "peanuts")
                    price = quantity * 1.50;
            }
            else if (city == "Varna")
            {
                if (product == "coffee")
                    price = quantity * 0.45;
                else if (product == "water")
                    price = quantity * 0.70;
                else if (product == "beer")
                    price = quantity * 1.15;
                else if (product == "sweets")
                    price = quantity * 1.35;
                else if (product == "peanuts")
                    price = quantity * 1.55;
            }

            Console.WriteLine(price);
        }

    }
}
