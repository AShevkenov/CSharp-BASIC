﻿using System;

namespace Password_guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            if (text == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
                Console.WriteLine("Wrong password!");
        }
    }
}
