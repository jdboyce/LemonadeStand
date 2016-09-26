using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Game
    {
        public Player player;
        public Day day;

        public Game()
        {
            player = new Player();
        }

        public void WelcomeScreen()
        {
            // http://www.messletters.com/en/big-text/

            Console.Clear();     
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine(@"                                     __    ___  __  __   __   _  _   __   ___   ___");
            Console.WriteLine(@"                                    (  )  (  _)(  \/  ) /  \ ( \( ) (  ) (   \ (  _)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"                                     )(__  ) _) )    ( ( () ) )  (  /__\  ) ) ) ) _)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"                                    (____)(___)(_/\/\_) \__/ (_)\_)(_)(_)(___/ (___)");
            Console.WriteLine("\n");
            Console.WriteLine(@"                                            ___  ____   __   _  _  ___    _");
            Console.WriteLine(@"                                           / __)(_  _) (  ) ( \( )(   \  / \");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"                                           \__ \  )(   /__\  )  (  ) ) ) \_/");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"                                           (___/ (__) (_)(_)(_)\_)(___/  (_)");           
        }

        public void StartGame()
        {
            Console.Write("\n\n\n                                                Press Enter To Start");
            Console.ReadLine();
            IntroAndExplanation();
        }


        public void IntroAndExplanation()
        {
            WelcomeScreen();
            Console.WriteLine("\n\n\n\n You have 7, 14, or 21 days to make as much money as possible, and you’ve decided to open a lemonade stand! "
                + "You’ll have\n complete control over your business, including pricing, quality control, inventory control, and purchasing supplies. \n"
                + " Buy your ingredients, make your recipe, and start selling! Oh, and be sure to keep your eye on the weather: some days \n are better than others "
                + "for selling lemonade. Be sure to adjust your prices accordingly! Good luck!");

            ChooseNumberOfDays();
        }


        public void ChooseNumberOfDays()
        {
            Console.Write("\n\n Please choose the number of days you'd like to play. Enter 7, 14, or 31: ");

            string playerInputAsString = Console.ReadLine();
            int playerInputAsInt = Convert.ToInt32(playerInputAsString);

            switch (playerInputAsInt)
            {
                case (7):
                case (14):
                case (31):
                    for (int dayNumber = 1; dayNumber < playerInputAsInt + 1; dayNumber++)
                    {
                        day = new Day(player, dayNumber);
                        day.RunDayTimeline();
                    }
                        break;
                default:
                        Console.WriteLine("\n Please enter a valid answer.\n");
                        ChooseNumberOfDays();
                        break;
            }
        }
    }
}
