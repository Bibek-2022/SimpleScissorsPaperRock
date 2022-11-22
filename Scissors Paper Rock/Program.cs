using System;

namespace Scissors_Paper_Rock
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int playerScore = 0;
            int oppScore = 0;

            Console.WriteLine("Welcome to ROCK PAPER SCISSORS");
            if (playerScore == 3) {
                Console.WriteLine("YOU LOOSE");
                    ;} else {
                Console.WriteLine("YOU WIN OVERALL"); }
            while (playerScore != 3 && oppScore != 3)
            {
                Console.WriteLine("Player score - " + playerScore + ". Enemy Score - " + oppScore);
                Console.WriteLine("Player enter 'r' for rock, 'p' for papper or anything else for scissors");
                string playerChoice = Console.ReadLine();

                int oppChoice = random.Next(0, 3);
                if(oppChoice == 0)
                {
                    Console.WriteLine("Enemy chooses rock.");
                    switch(playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Tie!!!");
                            break;
                        case "p":
                            Console.WriteLine("Player wins!!!");
                            playerScore++;
                            break;
                        default:
                            Console.WriteLine("Enemy Win!!!");
                            oppScore++;
                            break;

                    }
                } 
                else if (oppChoice == 1)
                {
                    Console.WriteLine("Enemy Chooses paper.");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Enemy win!!!");
                            oppScore++;
                            break;
                        case "s":
                            Console.WriteLine("Player wins!!!");
                            playerScore++;
                            break;
                        default:
                            Console.WriteLine("Tie!!!");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Enemy Chooses scissors");
                    switch (playerChoice)
                    {
                        case "s":
                            Console.WriteLine("Tie!!!");
                            break;
                        case "p":
                            Console.WriteLine("Enemy Win!!!");
                            oppScore++;
                            break;
                        default:
                            Console.WriteLine("Player Win !!!");
                            playerScore++;
                            break;

                    }
                }

            }
        }
    }
}
