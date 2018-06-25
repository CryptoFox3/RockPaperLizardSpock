using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperLizardSpock
{
    public abstract class Player
    {

        public int choice;
        public string name;
        public int score;

        public Player()
        {

        }

        public abstract void GetPlayerName();
        public abstract void ChooseGesture();
        

        
 
    }
   

}
