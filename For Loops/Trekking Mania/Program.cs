using System;

namespace For_Loops_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	На първия ред – броя на групите от катерачи – цяло число в интервала[1...1000]
            //•	За всяка една група на отделен ред – броя на хората в групата – цяло число в интервала[1...1000]

            int gropus = int.Parse(Console.ReadLine());

            int mussala = 0;
            int montblan = 0;
            int kilimandjaro = 0;
            int k2 = 0;
            int everst = 0;

            for (int i = 0; i < gropus; i++)
            {
                int ppl = int.Parse(Console.ReadLine());

                if (ppl <= 5)
                {
                    mussala += ppl;
                }
                else if (ppl <= 12)
                {
                    montblan += ppl;
                }
                else if (ppl <= 25)
                {
                    kilimandjaro += ppl;
                }
                else if (ppl <= 40)
                {
                    k2 += ppl;
                }
                else
                    everst += ppl;

            }
            double total = everst + k2 + kilimandjaro + montblan + mussala;

            Console.WriteLine($"{mussala / total * 100:f2}%");
            Console.WriteLine($"{montblan / total * 100:f2}%");
            Console.WriteLine($"{kilimandjaro / total * 100:f2}%");
            Console.WriteLine($"{k2 / total * 100:f2}%");
            Console.WriteLine($"{everst / total * 100:f2}%");
        }
    }
}
