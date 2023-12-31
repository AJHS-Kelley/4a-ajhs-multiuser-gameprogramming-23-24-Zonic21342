// Kyomari Brunswick, ExampleGameMethods, v1.6 Finale
using System;

/*
Rock paper scissors

need
player choice
cpu choice
score
*/

namespace exampleGameMethods
{
    class exampleGameMethods

    {
        static string playerPick()
        {
            // Let player pick their option
            Console.WriteLine("Type 'rock' 'paper' or 'scissors' in lowercase");
            string playerChoice = Console.ReadLine();

            while (true){
                if (playerChoice == "rock"){
                    Console.WriteLine("You picked rock");
                    break;
                } else if (playerChoice == "paper"){
                    Console.WriteLine("You picked paper");
                    break;
                } else if (playerChoice == "scissors"){
                    Console.WriteLine("You picked scissors");
                    break;
                } else {
                    Console.WriteLine("Try again");
                    // Need a break or return statement to exit the loop.  
                }
            }

            return playerChoice;
        }

        static string cpuPick()
        {
            // Cpu choice with random number
            string cpuChoice = "";
            int randomNumber = 0;
            Random rndNum = new Random();
            randomNumber = rndNum.Next(1, 3);
        
            
            if (randomNumber == 1){
                cpuChoice = "rock";
            } else if (randomNumber == 2){
                cpuChoice = "paper";
            } else if (randomNumber == 3){
                cpuChoice = "scissors";
            }

            // Console.WriteLine(randomNumber);
            Console.WriteLine("CPU picked " + cpuChoice);

            return cpuChoice;

        }

        static string winner(string pChoice, string cChoice)
        {
            // Choice possibilites
            string result = "";
            if (pChoice == cChoice){
            result = "tie";

            } else if (pChoice == "rock" && cChoice == "scissors"){
            result = "player";
            } else if (pChoice == "paper" && cChoice == "rock"){
            result = "player";
            } else if (pChoice == "scissors" && cChoice == "paper"){
            result = "player";

            } else if (cChoice == "rock" && pChoice == "scissors"){
            result = "cpu";
            } else if (cChoice == "paper" && pChoice == "rock"){
            result = "cpu";
            } else if (cChoice == "scissors" && pChoice == "paper"){
            result = "cpu";
            }

            return result;
        }

        static void score(string result)
        {
            // Says who wins
            if (result == "player"){
                Console.WriteLine("You won!");
            } else if (result == "cpu"){
                Console.WriteLine("You lost");
            } else if (result == "tie"){
                Console.WriteLine("You tied");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Time to play Rock, Paper, Scissors!");

            score(winner(playerPick(), cpuPick()));
  
        }
    }
}
