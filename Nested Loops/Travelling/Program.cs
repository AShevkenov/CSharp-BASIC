using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();// Greece
            double savedMoney = 0;


            while (destination != "End")
            {
                double savings = 0;
                double budged = double.Parse(Console.ReadLine());

                while (savings < budged)
                {
                    savings += double.Parse(Console.ReadLine());

                }
                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }
        }
    }
}
//using System;

//namespace Travelling
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string destination = Console.ReadLine();// Greece
//            double savedMoney = 0;
//            double savings = 0;

//            while (destination != "End")
//            {
//                double budged = double.Parse(Console.ReadLine());

//                while (savings <= budged)
//                {
//                    savedMoney = double.Parse(Console.ReadLine());
//                    savings += savedMoney;
//                    if (savings >= budged)
//                    {
//                        Console.WriteLine($"Going to {destination}!");
//                        savings = 0;
//                        savedMoney = 0;
//                        break;
//                    }
//                }
//                destination = Console.ReadLine();
//            }
//        }
//    }
//}
