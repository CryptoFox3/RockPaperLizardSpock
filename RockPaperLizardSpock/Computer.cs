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
        public override int ChooseGesture()
        {
             int RandomNumber(int 0, int 4);
            
                Random random = new Random();
                return random.Next(0, 4);

        }
    }

}
