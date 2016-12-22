using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        Player playerOne;
        Player playerTwo;
        List<string> moves = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };

        public void StartGame()
        {
            Rules rules = new Rules();
            rules.LearnRules();
            GetPlayers();
            RunGame();
        }
        public void RunGame()
        {
            while (playerOne.GetScore() < 2 && playerTwo.GetScore() < 2)
            {
                playerOne.MakeMove();
                playerTwo.MakeMove();
                DetermineWinner();

                Console.WriteLine("Keep playing until someone wins two rounds.");
            }
            GetScore();
            ChooseRestart();
        }
        public void ChooseRestart()
        {
            Console.WriteLine("Would you like to play another game? Type 'yes' or 'no'.");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "yes")
            {
                StartGame();
            }
            else if (userInput == "no")
            {
                Console.WriteLine("Have a nice day");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Error. Please write 'yes' or 'no'.");
                ChooseRestart();
            }
        }
        public void GetPlayers()
        {
            Console.WriteLine("Choose one or two players");
            Console.WriteLine("Type 'one' or 'two'");
            string numberOfPlayers = Console.ReadLine();

            if (numberOfPlayers.ToLower() == "one")
            {

                playerOne = new Human();
                playerTwo = new Computer();
            }
            else if (numberOfPlayers.ToLower() == "two")
            {
                playerOne = new Human();
                playerTwo = new Human();
            }
            else
            {
                Console.WriteLine("Invalid response. Write 'one' or 'two'");
                GetPlayers();
            }
        }
        public void GetScore()
        {
            if (playerOne.score > playerTwo.score)
            {
                Console.WriteLine("Player One Wins Game!");
            }
            else if (playerOne.score < playerTwo.score)
            {
                Console.WriteLine("Player Two Wins Game!");
            }
            else if (playerOne.score == playerTwo.score)
            {
                Console.WriteLine("Tie Game - Everybody Wins!");
            }
        }
        public void DetermineWinner()
        {
            if (playerOne.move == playerTwo.move)
            {
                Console.WriteLine("Tie game.");
                Console.WriteLine("Player one's hand was: {0}", playerOne.move);
                Console.WriteLine("Player two's hand was: {0}", playerTwo.move);
                playerOne.AddPointsToScore();
                playerTwo.AddPointsToScore();
            }

             else if (playerOne.move == "scissors" && playerTwo.move == "rock" || playerOne.move == "paper" && playerTwo.move == "scissors" || playerOne.move == "rock"
                && playerTwo.move == "paper" || playerOne.move == "Rock" && playerTwo.move == "lizard" || playerOne.move == "spock" && playerTwo.move == "paper" ||
               playerOne.move == "rock" && playerTwo.move == "lizard" || playerOne.move == "scissors" && playerTwo.move == "spock" || playerOne.move == "lizard" &&
               playerTwo.move == "spock" || playerOne.move == "spock" && playerTwo.move == "rock" || playerOne.move == "scissors" && playerTwo.move == "lizard")
            {
                Console.WriteLine("Player two wins!");
                Console.WriteLine("Player one's hand was: {0}", playerOne.move);
                Console.WriteLine("Player two's hand was: {0}", playerTwo.move);
                playerTwo.AddPointsToScore();
            }

            else if (playerOne.move == "paper" && playerTwo.move == "rock" || playerOne.move == "rock" && playerTwo.move == "scissors" || playerOne.move == "scissors"
                && playerTwo.move == "paper" || playerOne.move == "lizard" && playerTwo.move == "paper" || playerOne.move == "spock" && playerTwo.move == "scissors"
                || playerOne.move == "lizard" && playerTwo.move == "rock" || playerOne.move == "paper" && playerTwo.move == "spock" || playerOne.move == "spock"
                && playerTwo.move == "lizard" || playerOne.move == "rock" && playerTwo.move == "spock" || playerOne.move == "lizard" && playerTwo.move == "scissors")
            {
                Console.WriteLine("Player one wins!");
                Console.WriteLine("Player one's hand was: {0}", playerOne.move);
                Console.WriteLine("Player two's hand was: {0}", playerTwo.move);
                playerOne.AddPointsToScore();
            }

            else
            {
                Console.WriteLine("Invalid Entry. Please write 'Rock,' 'Paper,' 'Scissors,' 'Lizard,' or 'Spock.'");
                Console.WriteLine("Please try again: ");
                playerOne.move = Console.ReadLine();
                playerTwo.move = Console.ReadLine();
            }           
        }
    }
}

