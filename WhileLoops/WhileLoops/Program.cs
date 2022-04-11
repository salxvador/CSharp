using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to play a game? (yes/no):");
            string response = Console.ReadLine();
            bool play = false;

            //do-while loop checks if user enters 'yes' to play the game:
            do
            {
                switch (response)
                {
                    case "yes":
                        Console.WriteLine("Excellent! Let's begin...");
                        // set boolean to true when they answer yes
                        play = true;
                        break;
                    case "no":
                        Console.WriteLine("That's too bad, how about now?");
                        response = Console.ReadLine();
                        break;
                    default: //used when they enter an invalid string
                        Console.WriteLine("Please answer 'yes' or 'no':");
                        response = Console.ReadLine();
                        break;
                }
            }
            while (!play); // ensures that the loop is executed at least once.

            //Start the game:
            Console.WriteLine("Pick a number between 1 and 10:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("I will now count to "+ num + "!");
            // initialize counter variable at 0.
            int counter = 0;

            //WHILE loop without neend for 'do'
            while (counter < num) //boolean expression
            {
                //print value of the counter +1 (don't start at 0)
                Console.WriteLine(counter + 1);
                //add 1 to the counter, repeat the loop.
                counter++;
            }
            // Keep the console open so user can read the message.
            Console.Read();
        }
    }
}
