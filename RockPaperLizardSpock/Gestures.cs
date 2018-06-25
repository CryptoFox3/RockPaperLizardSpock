using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperLizardSpock
{
    class Gestures
    {




        public Gestures()
        {

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

   



