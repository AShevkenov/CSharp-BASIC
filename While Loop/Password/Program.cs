using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            int counter = 0;

            string enteredPassword = Console.ReadLine();

            while (enteredPassword != password)
            {
                counter++;
                if (counter == 3)
                {
                    Console.WriteLine("Wrong username or password!");
                    break;
                }

                enteredPassword = Console.ReadLine();
            }
            if (enteredPassword == password)
            Console.WriteLine($"Welcome {username}!");
        }
    }
}
