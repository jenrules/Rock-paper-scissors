using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Player
    {
              
        List <string> moves = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

        public int score;
        public int playerMove;

        public virtual void MakeMove()
        {
            Console.WriteLine("Error.You should see player move.");
        }
        public int GetScore()
        {
            return score;
        }
    }
}

