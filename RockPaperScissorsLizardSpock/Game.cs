using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        Player playerOne = new Player();
        Player playerTwo = new Player();
        List<string> moves = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };

        public void StartGame()
        {
            Rules rules = new Rules();
            rules.LearnRules();
            Player player = new Player();
            GetPlayers(player);
            Human human = new Human();
            human.MakeMove();
            Computer computer = new Computer();
            computer.MakeMove();
            DetermineWinner(player);
         }
              public void GetPlayers(Player player)
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
                GetPlayers(player);
            }
        }
        public void RunGame()
        {
            while (playerOne.GetScore() < 2 && playerTwo.GetScore() < 2)
            {
                playerOne.MakeMove();
                playerTwo.MakeMove();

                Console.WriteLine("Keep playing until someone wins two rounds.");
            }
        }
        public void DetermineWinner(Player player)
        {
            if (playerOne.move == playerTwo.move)
            {
                Console.WriteLine("Tie game.");
                Console.WriteLine("Player one's hand was: {0}", playerOne.move);
                Console.WriteLine("Player two's hand was: {0}", playerTwo.move);
            }

            else if (playerOne.move == "Rock" && playerTwo.move == "Scissors" || playerOne.move == "Scissors" && playerTwo.move == "Paper" || playerOne.move == "Paper"
                && playerTwo.move == "Rock" || playerOne.move == "Lizard" && playerTwo.move == "Rock" || playerOne.move == "Spock" && playerTwo.move == "Paper")
            {
                Console.WriteLine("Player two wins!");
                Console.WriteLine("Player one's hand was: {0}", playerOne.move);
                Console.WriteLine("Player two's hand was: {0}", playerTwo.move);
            }

            else if (playerOne.move == "Rock" && playerTwo.move == "Paper" || playerOne.move == "Scissors" && playerTwo.move == "Rock" || playerOne.move == "Paper"
                && playerTwo.move == "Scissors" || playerOne.move == "Lizard" && playerTwo.move == "Paper" || playerOne.move == "Spock" && playerTwo.move == "Scissors")
            {
                Console.WriteLine("Player one wins!");
                Console.WriteLine("Player one's hand was: {0}", playerOne.move);
                Console.WriteLine("Player two's hand was: {0}", playerTwo.move);
            }

            else
            {
                Console.WriteLine("Invalid Entry. Please write 'Rock,' 'Paper,' 'Scissors,' 'Lizard,' or 'Spock.'");
                Console.WriteLine("Please try again: ");
                player.move = Console.ReadLine();
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
        }
    }
}

