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
        public int wins;
        public int losses;

        public Player()
        {


        }
        

        public virtual int ChooseGesture()
        {
            int choice = 0;
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
            }
            return choice;

        }

        public string GestureList()
        {
                List<string> GestureList = new List<string>();
                GestureList.Add("rock");
                GestureList.Add("paper");
                GestureList.Add("scissors");
                GestureList.Add("spock");
                GestureList.Add("lizard");




            return GestureList[choice];
        }  
       
 
    }
   

}
