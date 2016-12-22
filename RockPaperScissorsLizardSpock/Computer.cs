using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Computer : Player
    {        
        Random pick = new Random();
        public override void MakeMove()
        {
            List<string> moves = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };
            move = moves[pick.Next(0, 5)];
        }
    }
}