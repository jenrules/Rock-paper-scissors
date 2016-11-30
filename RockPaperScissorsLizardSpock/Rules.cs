using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Rules
    {
        public void LearnRules()
        {
            Console.WriteLine("Welcome to the game Rock, Paper, Scissors, Lizard, Spock.");
            Console.WriteLine("Do you know the rules?");
            string rules = Console.ReadLine();
            if (rules.ToLower() == "no")
            {
                Console.WriteLine("You are going to play Rock, Paper, Scissors, Lizard, Spock.");
                Console.WriteLine("First, you are going to write down one of the five words.");
                Console.WriteLine("Whoever writes the stronger word, wins the round.");
                Console.WriteLine("Here are the rules for how the words relate to each other.");
                Console.WriteLine("Scissors cuts Paper.");
                Console.WriteLine("Paper covers Rock.");
                Console.WriteLine("Rock crushes Lizard.");
                Console.WriteLine("Lizard poisons Spock.");
                Console.WriteLine("Spock smashes Scissors.");
                Console.WriteLine("Scissors decapitates Lizard.");
                Console.WriteLine("Lizard eats Paper.");
                Console.WriteLine("Paper disproves Spock.");
                Console.WriteLine("Spock vaporizes Rock.");
                Console.WriteLine("Rock crushes Scissors.");
            }
            else if (rules.ToLower() == "yes")
            {
                Console.WriteLine("Great to have you play again!");
            }
            else
            {
                Console.WriteLine("Invalid response. Please write 'yes' or 'no.'");
                LearnRules();
            }
        }
    }
}
