using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperLizardSpock
{
    public class Player
    {
        public Player(Player temp)
        {
            this.Name = temp.Name;
            this.Wins = temp.Wins;
            this.Losses = temp.Losses;

        }
        public string Name;
        public int Wins;
        public int Losses;
        public Player()
    }
    public class Player2 : Player
    {

    }
    class AI
    {




       
    }
}
