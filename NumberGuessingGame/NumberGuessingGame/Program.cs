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
            string input;
            int low = 0;
            int high = 100;
            int guess;
            int count = 0;

            while(true)
            {
                guess = (low + high) / 2;
                Console.Write("Your guess is " + guess);
                input = Console.ReadLine();
                if(input == "h")
                {
                    low = guess + 1;
                    count = count + 1;
                }
                else if (input == "l")
                {
                    high = guess - 1;
                    count = count + 1;
                }
                else if (input == "e")
                {
                    count = count + 1;
                    break;
                }
            }

            if (count == 8)
            {
                Console.WriteLine("You lose (Went past maximum amount of guesses)");
            }
        }
    }
}
