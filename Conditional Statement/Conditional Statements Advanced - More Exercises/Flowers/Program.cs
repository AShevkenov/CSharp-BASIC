using System;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	На първия ред е броят на закупените хризантеми – цяло число в интервала[0... 200]
            //•	На втория ред е броят на закупените рози – цяло число в интервала[0... 200]
            //•	На третия ред е броят на закупените лалета – цяло число в интервала[0... 200]
            //•	На четвъртия ред е посочен сезона – [Spring, Summer, Аutumn, Winter]
            //•	На петия ред е посочено дали денят е празник – [Y – да / N - не]

            int chrysanthemum = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = (Console.ReadLine());

            double chrysanthemumPrice = 0;
            double rosesPrice = 0;
            double tulipsPrice = 0;

            int flowers = chrysanthemum + roses + tulips;

            if (season == "Spring" || season == "Summer")
            {
                chrysanthemumPrice = 2 * chrysanthemum;
                rosesPrice = 4.10 * roses;
                tulipsPrice = 2.50 * tulips;
            }
            else
            {
                chrysanthemumPrice = 3.75 * chrysanthemum;
                rosesPrice = 4.50 * roses;
                tulipsPrice = 4.15 * tulips;
            }
            double bucketPrice = chrysanthemumPrice + rosesPrice + tulipsPrice;
            if (holiday == "Y")
            {
                bucketPrice = chrysanthemumPrice + rosesPrice + tulipsPrice;
                bucketPrice = bucketPrice + (bucketPrice * 0.15);
            }


            if (tulips > 7 && season == "Spring")
            {
                bucketPrice = ((bucketPrice - (bucketPrice * 0.05)));

            }
            else if (roses >= 10 && season == "Winter")
            {
                bucketPrice = (bucketPrice - (bucketPrice * 0.1));

            }
            if (roses + chrysanthemum + tulips > 20)
            {
                bucketPrice = (bucketPrice - (bucketPrice * 0.2));

            }
            bucketPrice += 2;
            Console.WriteLine($"{bucketPrice:f2}");

        }
    }
}
