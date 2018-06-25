using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperLizardSpock
{
    public class Game
    {
        Player playerOne;
        Player playerTwo;


        public Game()
        {


        }

        public void RunGame()
        {
            Console.WriteLine("Welcome to the game! This game is just like Rock, Paper, Scissors, but with the addition of lizard and spock. \n ");
            SetGameType();

            RunRound();


        }

        public void SetGameType()
        {


            Console.WriteLine("What game type would you like to run? Please type 'single player' or 'multiplayer'");
            string gameType = Console.ReadLine().ToLower();


            if (gameType == "single player")
            {
                Console.WriteLine("You have chosen a single player game against an AI");
                playerOne = new Human();
                playerTwo = new Computer();    
            }
            else if (gameType == "multiplayer")
            {
                Console.WriteLine("You have chosen a multiplayer game against another person");
                playerOne = new Human();
                playerTwo = new Human();
            }
            else
            {
                Console.WriteLine("Follow the directions");
                SetGameType();
            }

        }




        public void RunRound()
        {
















        }
    }
}
