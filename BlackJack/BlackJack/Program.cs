using System;
using System.IO;
using Casino;
using Casino.BlackJack;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            // will be instantiated with the chained player constructor
            // if the data type is ever in question, you should declare it. Otherwise you can use var.
            //EXAMPLE: var newPlayer = new Player("Sal");

            //Greet and collect name
            Console.WriteLine("Welcome to the Grand Hotel Casino./n Let's start by telling me your name.");
            string playerName = Console.ReadLine();

            //Collect amount of money player has.
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}. Would you like to join a game of TwentyOne?", playerName);
            string answer = Console.ReadLine().ToLower();

            //construct payer and game if they answer 'yes'
            if (answer == "yes" || answer =="yeah" || answer== "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\KenAn\Desktop\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;

                // if the player is active and they have money, continue playing
                while(player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            //No need for an else statement
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();
        }
    }
}
