using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Kitchen
    {
        public Inventory inventory;
        public LemonadeStand lemonadeStand;
        public Pitcher pitcher;

        public int lemonsPerPitcher;
        public int cupsOfSugarPerPitcher;
        public int iceCubesPerPitcher;
        public int numberOfPitchers;


        public Kitchen(Inventory passedInventory, LemonadeStand passedLemonadeStand)
        {
            this.inventory = passedInventory;
            this.lemonadeStand = passedLemonadeStand;
        }


        public void ChooseRecipe()
        {
            Console.Write("\n Now let's choose a recipe. Each pitcher you make contains 20 cups of lemonade. Choose wisely!\n");
            ChooseNumerOfLemons();
            ChooseCupsOfSugar();
            ChooseNumberOfIceCubes();
        }


        public void ChooseNumerOfLemons()
        {
            Console.Write("\n How many lemons would you like per pitcher? Enter a number from 1-10: ");
            string amountAsString = Console.ReadLine();
            lemonsPerPitcher = Convert.ToInt32(amountAsString);
        }



        public void ChooseCupsOfSugar()
        {
            Console.Write("\n How many cups of sugar would you like per pitcher? Enter a number from 1-10: ");
            string amountAsString = Console.ReadLine();
            cupsOfSugarPerPitcher = Convert.ToInt32(amountAsString);
        }



        public void ChooseNumberOfIceCubes()
        {
            Console.Write("\n How many ice cubes would you like per cup? Enter a number from 1-10: ");
            string amountAsString = Console.ReadLine();
            iceCubesPerPitcher = Convert.ToInt32(amountAsString) * 20;
        }




        public void ChooseNumberOfPitchers()
        {
            Console.WriteLine("\n How many pitchers do you want to make for the day? ");
            string choosePitchers = Console.ReadLine();
            int numberOfPitchers = Convert.ToInt32(choosePitchers);
            if (inventory.cupsInStock.Count() >= numberOfPitchers * 20 && inventory.lemonsInStock.Count() >= numberOfPitchers * lemonsPerPitcher && inventory.cupsOfSugarInStock.Count() >= cupsOfSugarPerPitcher * numberOfPitchers && inventory.iceCubesInStock.Count() >= iceCubesPerPitcher * numberOfPitchers)
            {
                for (int i = 0; i < numberOfPitchers; i++)
                {
                    for (int cupsRequired = 0; cupsRequired < 20; cupsRequired++)
                        inventory.useCup();
                    for (int lemonsAdded = 0; lemonsAdded < lemonsPerPitcher; lemonsAdded++)
                        inventory.useLemon();
                    for (int sugarAdded = 0; sugarAdded < cupsOfSugarPerPitcher; sugarAdded++)
                        inventory.useSugar();
                    for (int iceAdded = 0; iceAdded < iceCubesPerPitcher; iceAdded++)
                        inventory.useIce();
                    pitcher = new Pitcher(lemonadeStand, lemonsPerPitcher, cupsOfSugarPerPitcher, iceCubesPerPitcher);
                    pitcher.PourCupsfLemonade();
                }
            }
            else
            {
                Console.WriteLine("\nSorry, you don't have enough inventory to make that many pitchers.\n");
                ChooseNumberOfPitchers();
            }
        }


        public bool CheckStock()
        {
            if (inventory.cupsInStock.Count() >= 20 && inventory.lemonsInStock.Count() >= lemonsPerPitcher && inventory.cupsOfSugarInStock.Count() >= cupsOfSugarPerPitcher && inventory.iceCubesInStock.Count() >= iceCubesPerPitcher)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public void MakePitcher()
        //{
        //    if (CheckStock())
        //    {
        //        for (int cupsRequired = 0; cupsRequired < 20; cupsRequired++)
        //            inventory.useCup();
        //        for (int lemonsAdded = 0; lemonsAdded < lemonsPerPitcher; lemonsAdded++)
        //            inventory.useLemon();
        //        for (int sugarAdded = 0; sugarAdded < cupsOfSugarPerPitcher; sugarAdded++)
        //            inventory.useSugar();
        //        for (int iceAdded = 0; iceAdded < iceCubesPerPitcher; iceAdded++)
        //            inventory.useIce();
        //        pitcher = new Pitcher(lemonadeStand, lemonsPerPitcher, cupsOfSugarPerPitcher, iceCubesPerPitcher);
        //        pitcher.PourCupsfLemonade();
        //    }
        //    else
        //    {
        //        return;
        //    }
        //}
    }
}
