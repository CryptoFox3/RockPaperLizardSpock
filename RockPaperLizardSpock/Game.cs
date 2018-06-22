using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperLizardSpock
{
    class Game
    {
        


        public Game()
        {
            StartGame();

        }

        public void StartGame()
        {
            Console.WriteLine("Welcome to the game! RULES HERE");

            Console.WriteLine("What game type would you like to run? Please type 'single player' 'multiplayer' or 'simulation'");
            string gameType = Console.ReadLine();
            gameType.ToLower();

            if (gameType == "single player")
            {
                Player playerOne = new Human();
                Player playerTwo = new Computer();
            }
            else if (gameType == "multiplayer")
            {
                Player playerOne = new Human();
                Player playerTwo = new Human();
            }
            else (gameType == "simulation")
            {
                Player playerOne = new Computer();
                Player playerTwo = new Computer();
            }

            RunRound();

        }




        public void RunRound()
        {
            int gesture = playerOne.ChooseGesture();
            int gesture2 = playerTwo.ChooseGesture();

            Console.WriteLine("Player 1 has chosen " + playerOne.GestureList(gesture);


            Console.WriteLine("Player 2 has chosen " + playerTwo.GestureList(gesture2);








            
int winner = (5 + gesture - gesture2) % 5;

            




            if (playerOne.wins == 2)
            {
                Console.WriteLine("");
            }

            if (playerTwo.wins == 2)
            {
                Console.WriteLine("");
            }
        }

        

        
    }
}
