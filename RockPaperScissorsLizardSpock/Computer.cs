using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Computer : Player
    {
        Random random = new Random();
        public string move;
        public override void MakeMove()
        {
            List<string> moves = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            int randX = random.Next(0, 5);
            move = randX.ToString(move);
         }
    }
}