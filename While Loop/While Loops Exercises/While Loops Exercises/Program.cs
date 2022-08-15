using System;

namespace While_Loops_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();

            int counter = 0;

            string bookRightNow = Console.ReadLine();

            while (bookRightNow != "No More Books")
            {
                if (bookRightNow == favouriteBook)
                {
                    break;
                }
                counter++;
                bookRightNow = Console.ReadLine();
            }
            if (bookRightNow == favouriteBook)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
