using System;

namespace Scissors_Paper_Rock
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerScore = 0;
            int oppScore = 0;

            Console.WriteLine("Welcome to ROCK PAPER SCISSORS");

            while (playerScore != 3 && oppScore != 3)
            {
                Console.WriteLine("Player score - " + playerScore + ". Enemy Score - " + oppScore);
            }
        }
    }
}
