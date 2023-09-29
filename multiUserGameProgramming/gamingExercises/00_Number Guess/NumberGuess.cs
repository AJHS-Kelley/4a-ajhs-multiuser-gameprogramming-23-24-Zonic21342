// Kyomari Brunswick, Number Guess, v0.5.5
/*
Generate secret number from a defined range of numbers (0-10, 0-50, 0-100)
Print game instructions including range and num. of guesses allowed.
    Match == first player to score 3 points.
    Round == guessing a specific number, until correct or no more attempts
Ask the player what difficulty they want to play on.
Ask the player what their guess is.
Determine if guess is correct or not.
    if guess is correct {
        Tell them they have guessed correctly.
        Award the player a point.
    } else {
        Tell them they are wrong.
        Tell player if guess is too high or too low.
        check to see if they have guesses remaining {
            if guess remain: {
                allow player to guess again.
            } else {
                CPU wins the round.
            }
        }
    }

*/
using Sytem;

namespace numberGuess
{
    class numberGuess
    {
        static void Main(string[] args)
        {
            int secretNumber = -1;
            int numGuesses = 0; // NUMBER OF GUESSES PLAYER IS ALLOWED
            int numAttempts =0; // NUMBER OF GUESSES TAKEN.
            int playerGuess =0;
            int playerScore =0;
            int cpuScore =0;
            string difficulty = "";
            int rangeMin = -1;
            int rangeMax = -1;

            Console.WriteLine("Welcome to the Number Guess Game!\nYou'll select a difficulty next.\n");
        }
    }
}