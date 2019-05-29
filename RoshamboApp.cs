using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
    public class RoshamboApp : IApp
    {
        public void Run()
        {
            throw new NotImplementedException();
        }

        //private bool IsWinner()
        //{
        //    if ((userInput.Equals("scissors", StringComparison.OrdinalIgnoreCase)
        //                && computerInput == Roshambo.Rock)
        //                    || ((userInput.Equals("rock", StringComparison.OrdinalIgnoreCase)
        //                && computerInput == Roshambo.Paper))
        //                    || ((userInput.Equals("paper", StringComparison.OrdinalIgnoreCase))
        //                && computerInput == Roshambo.Scissors))
        //    {
        //        return true;
        //    }
        //    if (computerInput.Equals(userInput))
        //    {
        //        Console.WriteLine("Draw");
        //    }
        //    if ((userInput.Equals("rock", StringComparison.OrdinalIgnoreCase) && computerInput == Roshambo.Scissors) || ((userInput.Equals("paper", StringComparison.OrdinalIgnoreCase) && computerInput == Roshambo.Rock)) || ((userInput.Equals("scissors", StringComparison.OrdinalIgnoreCase)) && computerInput == Roshambo.Paper))
        //    {
        //        Console.WriteLine("You win.");
        //    }
        //}
    }

    public interface IApp
    {
        void Run();
    }
}
