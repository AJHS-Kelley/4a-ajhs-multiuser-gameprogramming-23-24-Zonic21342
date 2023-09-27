// Kyomari Brunswick, NumberGuess, v0.03
/*
Generate secret number from a defined of numbers (ex:1-10)
Print game instructions including range and number of guesses allowed.
    MATCH == first player to score 3 points.
    ROUND == guessing a specific number, until correct or no more attempts
Ask the player what difficulty they want to play on.
Ask the player what their guess is.
Determine if guess is correct or not.
    If guess is correct
    {
        Tell them they have guesses correctly.
        Give the player a point.
    }else
    {
        Tell them they are wrong.
        Tell player if guess is too high or too low.
        Check to see if they have guesses remaining
        {
            if guess remain:
            {
                allow player to guess again.
            }else
            {
                CPU wins the round.
            }
        }
    }

*/
using System;

namespace NumberGuess
{
    class NumberGuess
    {
        static void Main(string[] args)
        {
            int secretNumber = -1;
            int numGuesses = 0; // Number of guesses player is ALLOWED.
            int  numAttemps = 0; // NUMBERS of guesses TAKEN.
            int playerScore = 0;
            int cpuScore = 0;
            string difficulty = "";
            int rangeMin = -1;
            int rangeMax = -1;

            Console.WriteLine("Number Guess Game\nSelect your difficulty next.\n");
            Console.WriteLine("Easy mode: 0 - 10 with 4 guesses.\nNorml mode: Range is o - 25 with 4 guesses.")

            // DIFFICULTY SLECTION
            Console.WriteLine("enter Easy, Normal, or hard.")
            difficulty = Console.ReadLine();
            //Console
        }
    }
}
