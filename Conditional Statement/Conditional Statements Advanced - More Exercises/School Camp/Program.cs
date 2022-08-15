using System;

namespace School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Сезонът – текст - “Winter”, “Spring” или “Summer”;
            //2.Видът на групата – текст - “boys”, “girls” или “mixed”;
            //3.Брой на учениците – цяло число в интервала[1 … 10000];
            //4.Брой на нощувките – цяло число в интервала[1 … 100].

            string season = Console.ReadLine();
            string group = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            double pricePerNight = 0;
            string sport = "";

            if (season == "Winter")
            {
                if (group == "boys" || group == "girls")
                {

                    pricePerNight = students * 9.60;
                }
                else
                {
                    pricePerNight = students * 10.00;
                }
            }
            else if (season == "Spring")
            {
                if (group == "boys" || group == "girls")
                {
                    pricePerNight = students * 7.20;
                }
                else
                {
                    pricePerNight = students * 9.50;
                }
            }
            else
            {
                if (group == "boys" || group == "girls")
                {
                    pricePerNight = students * 15.00;
                }
                else
                {
                    pricePerNight = students * 20.00;
                }
            }
            if (students >= 50)
            {
                pricePerNight = pricePerNight * 0.5;
            }
            else if (students >= 20)
            {
                pricePerNight = pricePerNight - (pricePerNight * 0.15);
            }
            else if (students >= 10)
            {
                pricePerNight = pricePerNight - (pricePerNight * 0.05);
            }
            pricePerNight = pricePerNight * nights;
            if (season == "Winter")
            {
                if (group == "boys")
                {
                    sport = "Judo";
                }
                else if (group == "girls")
                {
                    sport = "Gymnastics";
                }
                else
                {
                    sport = "Ski";
                }
            }
            else if (season == "Spring")
            {
                if (group == "boys")
                {
                    sport = "Tennis";
                }
                else if (group == "girls")
                {
                    sport = "Athletics";
                }
                else
                {
                    sport = "Cycling";
                }
            }
            else
            {
                if (group == "boys")
                {
                    sport = "Football";
                }
                else if (group == "girls")
                {
                    sport = "Volleyball";
                }
                else
                {
                    sport = "Swimming";
                }
            }

            Console.WriteLine($"{sport} {pricePerNight:f2} lv.");
        }

    }
}
