using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int guess;
            {
                for (int i = 1; i < 100; i++);
            }
                Console.WriteLine("I'm thinking of a number between 1 and 100. What is it?");
                string input = Console.ReadLine(); // Accept a string from the user
                string input.ToInt32 = guess;

                // if (input == "y")
                // {
                // do something
                // }

                if (guess < number)
                {
                    Console.WriteLine("H");
                }

                if (guess > number)
                {
                    Console.WriteLine("L");
                }

                if (guess == number)
                {
                    Console.WriteLine("E");
                }
        }
    }
}
