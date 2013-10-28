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
            int tries = 0;
            int h = 100;
            int l = 0;


                Console.WriteLine("Think of a number between 1 and 100. Is it...?");
                string input = Console.ReadLine(); // Accept a string from the user
                    

                // if (input == "y")
                // {
                // do something
                // }

                if (input == "H")
                {
                    
                }
                
                if(input == "L")
                {
                    
                }
                
                if (input == "E")
                {
                    Console.WriteLine("That is the Number!");
                }
        
                if (tries <= 7)
                {
                    Console.WriteLine("You win");
                }

                if (tries > 7)
                {
                    Console.WriteLine("You lose");
                }
        }
    }
}
