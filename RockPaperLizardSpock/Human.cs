using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperLizardSpock
{
    class Human : Player
    {

        public Human()
        {

        }


        public override void ChooseGesture()
        {

            Console.WriteLine("Please enter your gesture of choice for this round. \n Your options are: 'rock', 'paper', 'scissors', 'lizard', 'spock'");
            string switchCondition = Console.ReadLine();
            switchCondition.ToLower();

            switch (switchCondition)
            {
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

            public override void GetPlayerName()
            {
            Console.WriteLine("Please enter a name for your player");
            name = Console.ReadLine();
            }


    }
    }

