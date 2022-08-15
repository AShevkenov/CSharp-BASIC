using System;

namespace Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int Seats = int.Parse(Console.ReadLine());

            double standart = 0;
            double student = 0;
            double kid = 0;
            double standartTotal = 0;
            double studentTotal = 0;
            double kidTotal = 0;

            double totalTickets = 0;

            double percentage = 0;

            string typeOfTicket = "";

            while (movieName != "Finish")
            {
                typeOfTicket = Console.ReadLine();

                while (typeOfTicket != "End")
                {
                    totalTickets++;
                    if (typeOfTicket == "standard")
                    {
                        standart++;
                        standartTotal++;
                    }
                    else if (typeOfTicket == "student")
                    {
                        student++;
                        studentTotal++;
                    }
                    else
                    {
                        kid++;
                        kidTotal++;
                    }
                    if (Seats == student + standart + kid)
                    {
                        break;
                    }
                    typeOfTicket = Console.ReadLine();
                }
                percentage = ((student + kid + standart)*1.00) / Seats * 100;
                Console.WriteLine($"{movieName} - {percentage:f2}% full.");
                movieName = Console.ReadLine();
                if (movieName == "Finish")
                {
                    break;
                }
                Seats = int.Parse(Console.ReadLine());
                student = 0;
                kid = 0;
                standart = 0;
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(studentTotal / totalTickets * 100):f2}% student tickets.");
            Console.WriteLine($"{(standartTotal / totalTickets * 100):f2}% standard tickets.");
            Console.WriteLine($"{(kidTotal / totalTickets * 100):f2}% kids tickets.");
        }
    }
}
