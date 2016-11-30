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
        List<string> moves = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        public void StartGame()
        {
            Rules rules = new Rules();
            rules.LearnRules();
            GetPlayers();
            Player player = new Player();
            Human human = new Human();
            human.MakeMove();
            Computer computer = new Computer();
            computer.MakeMove();
            player.GetScore();
            GetScore();
            DetermineWinner();
         }
        
        public void RunGame()
        {
            while (playerOne.score < 2 && playerTwo.score < 2)
                
             {
                Console.WriteLine("Keep playing until someone wins two rounds.");
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

        public void DetermineWinner()
        {
            string playerOneMove = null;
            string playerTwoMove = null;

            if (playerOneMove == playerTwoMove)
            {
                Console.WriteLine("Tie game.");
                Console.WriteLine("Player one's hand was: {0}", playerOneMove);
                Console.WriteLine("Player two's hand was: {0}", playerTwoMove);
            }

            else if (playerOneMove == "Rock" && playerTwoMove == "Scissors" || playerOneMove == "Scissors" && playerTwoMove == "Paper" || playerOneMove == "Paper"
                && playerTwoMove == "Rock" || playerOneMove == "Lizard" && playerTwoMove == "Rock" || playerOneMove == "Spock" && playerTwoMove == "Paper")
            {
                Console.WriteLine("Player two wins!");
                Console.WriteLine("Player one's hand was: {0}", playerOneMove);
                Console.WriteLine("Player two's hand was: {0}", playerTwoMove);
            }

            else if (playerOneMove == "Rock" && playerTwoMove == "Paper" || playerOneMove == "Scissors" && playerTwoMove == "Rock" || playerOneMove == "Paper"
                && playerTwoMove == "Scissors" || playerOneMove == "Lizard" && playerTwoMove == "Paper" || playerOneMove == "Spock" && playerTwoMove == "Scissors")
            {
                Console.WriteLine("Player one wins!");
                Console.WriteLine("Player one's hand was: {0}", playerOneMove);
                Console.WriteLine("Player two's hand was: {0}", playerTwoMove);
            }

            else
            {
                Console.WriteLine("Invalid Entry. Please write 'Rock,' 'Paper,' 'Scissors,' 'Lizard,' or 'Spock.'");
                Console.WriteLine("Please try again: ");
                playerOneMove = Console.ReadLine();
                playerTwoMove = Console.ReadLine();
                DetermineWinner();
            }
        }
            public void GetScore()
        {
            
        }
    }
}

