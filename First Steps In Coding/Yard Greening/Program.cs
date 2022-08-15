using System;

namespace Nums1To10
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMeters = double.Parse(Console.ReadLine());
            double pricePerSquareMeter = 7.61;
            double totalPrice = (squareMeters * pricePerSquareMeter);
            double discount = totalPrice * 0.18;
            double finalPrice = totalPrice - discount;
            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");


        }
    }
}