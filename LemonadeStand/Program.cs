using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Program
    {
        static void Main(string[] args)
        {

            Game newGame = new Game();

            newGame.WelcomeScreen();

            newGame.StartGame();

            Console.ReadLine();
        }
    }
}
