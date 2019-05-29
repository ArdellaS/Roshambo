using System;
using System.Collections.Generic;

namespace Roshambo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Let's play rock, paper, scissors! Would you like an easy or a hard opponent?\n");
            var playerType = Console.ReadLine();
            playerType.ToLower();

            var playerOne = new Player1("Player One");
            var playerTwo = new Player2("Player Two");
            var userPlayer = new Player3("Main player");

            var answer = "yes";
           
            if (playerType.Equals("easy", StringComparison.OrdinalIgnoreCase))
            {
                do
                {
                    
                Console.Write("Rock, Paper, Scissor. Shoot! Enter your selection: \n");

                var userInput = Console.ReadLine();
                    

               Console.WriteLine($"Computer chooses {playerOne.GenerateRoshambo()}\n");
                if (userInput.Equals("scissors", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Computer wins.\n");
                }
                if (userInput.Equals("rock", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Draw\n");
                }
                if (userInput.Equals("paper", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You win.\n");
                }
               
                Console.WriteLine("Try again? (yes/no)\n");
                answer = Console.ReadLine();
                } while (answer == "yes");

            }
            if (playerType.Equals("hard", StringComparison.OrdinalIgnoreCase))
            {
                do
                {
                    Console.Write("Rock, Paper, Scissor. Shoot! Enter your selection: \n");
                    var userInput = Console.ReadLine();
                    var computerInput = playerTwo.GenerateRoshambo();
                    
                    Console.WriteLine($"You chose {userInput} and Computer chooses {computerInput}\n");
                    

                    if ((userInput.Equals("scissors", StringComparison.OrdinalIgnoreCase) 
                        && computerInput == Roshambo.Rock) 
                            || ((userInput.Equals("rock", StringComparison.OrdinalIgnoreCase) 
                        && computerInput == Roshambo.Paper)) 
                            || ((userInput.Equals("paper", StringComparison.OrdinalIgnoreCase)) 
                        && computerInput == Roshambo.Scissors))
                    {
                        // return true
                        Console.WriteLine("Computer wins.\n");
                    }
                    if (computerInput.Equals(userInput))
                    {
                        Console.WriteLine("Draw.\n");
                    }
                    if ((userInput.Equals("rock", StringComparison.OrdinalIgnoreCase) && computerInput == Roshambo.Scissors) || ((userInput.Equals("paper", StringComparison.OrdinalIgnoreCase) && computerInput == Roshambo.Rock)) || ((userInput.Equals("scissors", StringComparison.OrdinalIgnoreCase)) && computerInput == Roshambo.Paper))
                    {
                        Console.WriteLine("You win.\n");
                    }
                     Console.WriteLine("Try again?(yes/no)\n");
                    answer = Console.ReadLine();
                } while (answer == "yes");
           
           }
            
   
        }
    }
}