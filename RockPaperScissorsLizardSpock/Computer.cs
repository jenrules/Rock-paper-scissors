using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Computer : Player
    {
        List<string> moves = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };
        Random pick = new Random();
        public override void MakeMove()
        {
            move = moves[pick.Next(0, 5)];
        }
    }
}