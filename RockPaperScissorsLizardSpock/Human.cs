using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Human : Player
    {
            public override void MakeMove()
            {
            Console.WriteLine("Please choose 'Rock,' 'Paper,' Scissors,' 'Lizard,' 'Spock.'");
            string userMove = Console.ReadLine().ToLower();
            switch (userMove)
            {
                case "rock":
                    move = userMove;
                    break;
                case "paper":
                    move = userMove;
                    break;
                case "scissors":
                    move = userMove;
                    break;
                case "lizard":
                    move = userMove;
                    break;
                case "spock":
                    move = userMove;
                    break;
                default:
                    Console.WriteLine("Invalid response. Please choose a valid response.");
                    MakeMove();
                    break;
            }
        }
    }
}

