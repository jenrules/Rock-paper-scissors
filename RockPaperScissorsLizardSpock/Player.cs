using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Player
    {
        public int score = 0;
        public string move;
        public virtual void MakeMove()
        {
            Console.WriteLine("Error.You should see player move.");
            throw new Exception();
        }
        public int GetScore()
        {
            return score;
        }
        public void AddPointsToScore()
        {
            score++;
        }
        public string GetMove()
        {
        return move;
        }
    }
}

