using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperLizardSpock
{
    class Computer : Player
    {

        public Computer()
        {

        }
        public override void ChooseGesture()
        {
             
            
                Random random = new Random();
                choice = random.Next(0, 4);

        }

        public override void GetPlayerName()
        {
            name = "Computer Player";
        }
    }

}
