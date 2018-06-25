using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperLizardSpock
{
    public class Player
    {

        public int choice;
        public string name;
        public int score;

        public Player()
        {


        }
        

        public virtual void ChooseGesture()
        {
            
            Console.WriteLine("Please enter your gesture of choice for this round. \n Your options are: 'rock', 'paper', 'scissors', 'lizard', 'spock'");
            string switchCondition = Console.ReadLine();
            switchCondition.ToLower();

            switch (switchCondition) { 
                case "rock":
                    choice = 0;
                    break;
                case "paper":
                    choice = 1;
                    break;
                case "scissors":
                    choice = 2;
                    break;
                case "spock":
                    choice = 3;
                    break;
                case "lizard":
                    choice = 4;
                    break;
                default:
                    Console.WriteLine("Please enter a valid gesture");
                    ChooseGesture();
                    break;
            }
            

        }

        private static List<string> GestureList()
        {
            List<string> GestureList = new List<string>();
            GestureList.Add("Scissors cuts Paper");
            GestureList.Add("Paper covers Rock");
            GestureList.Add("Rock crushes Lizard");
            GestureList.Add("Lizard poisons Spock");
            GestureList.Add("Spock smashes Scissors");
            GestureList.Add("Scissors decapitates Lizard");
            GestureList.Add("Lizard eats Paper");
            GestureList.Add("Paper disproves Spock");
            GestureList.Add("Spock vaporizes Rock");
            GestureList.Add("Rock crushes Scissors");
            return GestureList;
        }  
       
 
    }
   

}
