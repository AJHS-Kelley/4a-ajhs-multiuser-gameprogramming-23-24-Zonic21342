// Kyomari Brunswick, Number Guess, v.1
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
            Console.WriteLine("Easy Mode: Range is 0 - 10 with 4 gusses.\nNormal Mode: Range is 0 - 25 with 4 gusses.\nHard Mode: range is 0 - 50 with 3 guesses.\n");

            // DIFICULTY SELECTION
            Console.WriteLine("Welcome type Easy, Normal, or Hard and press ENTER.");
            difficulty = Console.RedLine();
            // Console.RedLine() will save to STRING by defualt.
            Console.WriteLine("You have selected " + difficulty);
            if (difficulty == "Easy") {
                rangeMin = 0;
                rangeMax = 10;
                numberGuess = 4;
            }else if (difficulty == "Normal") {
                rangeMin = 0;
                rangeMax = 25;
                numberGuess = 4;
            } else if (difficulty == "Hard") {
                rangeMin = 0;
                rangeMax = 50;
                numberGuess = 3;
            } else {
                // CODE TO RUN IF NO DIFFICULTY IS SELECTED.
                Console.WriteLine("No difficulty selected corretly, defaulting to Normal.\n");
                rangeMin = 0;
                rangeMax = 25;
                numberGuess = 4;
            }
            Console.WriteLine("Minium: " + rangeMin);
            Console.WriteLine("Maxium: " + rangeMax);
            Console.WriteLine("Num. Guesses: " + numberGuesses);

            // START THE PATCH
            while (playerScore != 3 && cpuScore != 3) {
                // Any code you want to run BEFORE each round goes here.
                // GENERATE SECRET NUMBER
                Random rndNum = new Random();
                secretNumber = rndNum.Next(rangeMin, rangeMax);
                Console.WriteLine(secretNumber); // REMOVE AFTER TESTING
                Console.WriteLine("Player Score: " + playerScore + "\n");
                Console.WriteLine("cpuScore Score: " + cpuScore + "\n");
                // START EACH ROUND
                for (int i = 0; i < numGuesses ; i++) {
                    // Code to guess number goes here.
                    Console.WriteLine("You have used " + numAttempts + " this round.\n");
                    Console.WriteLine("You must guess between " + rangeMin + "and " + rangeMax + ".\n");
                    playerGuess = System.Convert.ToInt32(Console.ReadLine());
                    if (playerGuess == secretNumber) {
                        // Print a success message!
                        playerScore++;
                        break;
                    } else {
                        if (playerGuess > secretNumber) {
                            Console.WriteLine("Your guess is too high!\n");
                        } else {
                            Console.WriteLine("your is too low!\n");
                        }
                    }
                    numAttempts++;
                }
                if (playerGuess != secretNumber) {
                    cpuScore++;
                    //Prit a round lost message to the console.
                }
            }
            if (playerScore >= 3) {
                Console.WriteLine("You have won the game!\n");
            } else {
                Console.WriteLine("You have lost the game!\n");
            }

        }
    }
}