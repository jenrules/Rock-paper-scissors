using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Human : Player
    {
        public int move;
        List<string> moves = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        public override void MakeMove()
            {
            Console.WriteLine("Please choose 'Rock,' 'Paper,' Scissors,' 'Lizard,' 'Spock.'");
            string makeMove = Console.ReadLine().ToLower();

            switch (makeMove)
            {
                case "rock":
                    move = playerMove;
                    break;
                case "paper":
                    move = playerMove;
                    break;
                case "scissors":
                    move = playerMove;
                    break;
                case "lizard":
                    move = playerMove;
                    break;
                case "spock":
                    move = playerMove;
                    break;
                default:
                    Console.WriteLine("Invalid response. Please choose a valid response.");
                    MakeMove();
                    break;
            }
        }
    }
}

