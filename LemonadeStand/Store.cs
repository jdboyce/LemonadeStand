using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Store
    {
        public Player player;
        public Weather weather;
        public int dayNumber;

        public List<Item> stock = new List<Item>();

        public BagOfCups bagOfCups;
        public BagOfLemons bagOfLemons;
        public BagOfSugar bagOfSugar;
        public BagOfIce bagOfIce;

        public Store(Player passedPlayer, Weather passedWeather, int passedDayNumber)
        {
            player = passedPlayer;
            weather = passedWeather;
            dayNumber = passedDayNumber;
            bagOfCups = new BagOfCups();
            bagOfLemons = new BagOfLemons();
            bagOfSugar = new BagOfSugar();
            bagOfIce = new BagOfIce();
        }

        public void GoShopping()
        {
            DisplayStatus();
            stock.Add(bagOfCups);
            stock.Add(bagOfLemons);
            stock.Add(bagOfSugar);
            stock.Add(bagOfIce);
            Console.WriteLine("Time to go shopping! Select the amount of items you think you will need for the day.\n");
            ChooseItems();
        }

        public void ChooseItems()
        {
            for (int stockItemType = 0; stockItemType < stock.Count(); stockItemType++)
            {
                if (stock[stockItemType].cost <= player.cashBox.cashOnHand)
                {
                    Console.Write("\nA bag of {0} costs ${1}, and each bag contains {2}. How many bags would you like to buy?\n" +
                    "Enter a number from 0 to 10:  ", stock[stockItemType].name, stock[stockItemType].cost, stock[stockItemType].contains);
                    BuyItem(stock[stockItemType]);
                }
                else
                {
                    Console.WriteLine("Sorry, you don't have enough money to buy {0} right now.", stock[stockItemType].name);
                    DisplayStatus();
                }
            }
        }

        public void BuyItem(Item passedItem)
        {
            Item itemType = passedItem;
            string playerInputString = Console.ReadLine();
            int playerInput = Convert.ToInt32(playerInputString);
            decimal totalCost = playerInput * itemType.cost;

            if (playerInput <= 0)
            {
                Console.WriteLine("Alright, moving on.\n");
                DisplayStatus();
            }
            else if (playerInput > 10)
            {
                Console.WriteLine("Please enter a valid answer.");
                BuyItem(itemType);
            }
            else
            {
                player.cashBox.PayForItems(totalCost);
                for (int i = 0; i < playerInput; i++)
                {
                    player.inventory.AddItemsToInventory(itemType.name);
                    DisplayStatus();
                }
            }
        }


        public void DisplayStatus()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("             Day: {0}    |    Cash On Hand: ${1}    |    Temperature: {2}    |    Weather Forecast: {3}\n", dayNumber, player.cashBox.cashOnHand, weather.temperature, weather.weatherForecast);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                 Cups: {0}     |     Lemons: {1}     |     Cups of Sugar: {2}     |     Ice Cubes: {3}\n", player.inventory.cupsInStock.Count(), player.inventory.lemonsInStock.Count(), player.inventory.cupsOfSugarInStock.Count(), player.inventory.iceCubesInStock.Count());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————\n\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}


        //public void BuyCups()
        //{
        //    Console.WriteLine("Cups are $0.05 a piece. How many do you want to buy? Enter 0, 20, 50, 100, 200, or 300:");
        //    SelectNumberOfCupsToBuy();
        //}


        //public void BuyLemons()
        //{
        //    Console.WriteLine("\nLemons are $0.25 a piece. How many do you want to buy? Enter 0, 5, 10, 25, 50, or 100:");
        //    SelectNumberOfLemonsToBuy();
        //}


        //public void BuySugar()
        //{
        //    Console.WriteLine("\nSugar is $0.20 per cup. How many cups do you want to buy? Enter 0, 5, 10, 25, 50, or 100:");
        //    SelectCupsOfSugarToBuy();
        //}


        //public void BuyIce()
        //{
        //    Console.WriteLine("\nIce is $1.00 per bag, with 100 ice cubes in each bag. How many bags of ice do you want to buy? Enter 0, 1, 3, 5, 7, or 9:");
        //    SelectNumberOfIceCubesToBuy();
        //}








        //public void SelectItemsToBuy()
        //{
        //    string playerInputString = Console.ReadLine();
        //    int playerInputAsInt = Convert.ToInt32(playerInputString);
        //    decimal costOfPurchase = playerInputAsInt * 0.05m;
        //    switch (playerInputAsInt)
        //    {
        //        case (0):
        //            Console.WriteLine("Alright, next item.\n");
        //            break;
        //        case (20):
        //        case (50):
        //        case (100):
        //        case (200):
        //        case (300):
        //            if (player.cashBox.CheckIfEnoughCash(costOfPurchase))
        //            {
        //                for (int buyQauntity = 0; buyQauntity < playerInputAsInt; buyQauntity++)
        //                    sellCup();
        //            }
        //            else
        //            {
        //                Console.WriteLine("Sorry, you don't have enough money available to buy that many cups at this time.\n");
        //                SelectNumberOfCupsToBuy();
        //            }
        //            break;

        //        default:
        //            Console.Write("Please enter a valid answer.\n");
        //            SelectNumberOfCupsToBuy();
        //            break;
        //    }
        //}























        //public void SelectNumberOfCupsToBuy()
        //{
        //    string playerInputAsString = Console.ReadLine();
        //    int playerInputAsInt = Convert.ToInt32(playerInputAsString);
        //    decimal costOfPurchase = playerInputAsInt * 0.05m;
        //    switch (playerInputAsInt)
        //    {
        //        case (0):
        //            Console.WriteLine("Alright, next item.\n");
        //            break;
        //        case (20):
        //        case (50):
        //        case (100):
        //        case (200):
        //        case (300):
        //            if (player.cashBox.CheckIfEnoughCash(costOfPurchase))
        //            {
        //                for (int buyQauntity = 0; buyQauntity < playerInputAsInt; buyQauntity++)
        //                sellCup();
        //            }
        //            else
        //            {
        //                Console.WriteLine("Sorry, you don't have enough money available to buy that many cups at this time.\n");
        //                SelectNumberOfCupsToBuy();
        //            }
        //            break;

        //        default:
        //            Console.Write("Please enter a valid answer.\n");
        //            SelectNumberOfCupsToBuy();
        //            break;
        //    }
        //}

        //public void SelectNumberOfLemonsToBuy()
        //{
        //    string playerInputAsString = Console.ReadLine();
        //    int playerInputAsInt = Convert.ToInt32(playerInputAsString);
        //    decimal costOfPurchase = playerInputAsInt * 0.25m;
        //    switch (playerInputAsInt)
        //    {
        //        case (0):
        //            Console.WriteLine("\nAlright, next item.\n");
        //            break;
        //        case (5):
        //        case (10):
        //        case (25):
        //        case (50):
        //        case (100):
        //            if (player.cashBox.CheckIfEnoughCash(costOfPurchase))
        //            {
        //                for (int buyQauntity = 0; buyQauntity < playerInputAsInt; buyQauntity++)
        //                sellLemon();
        //            }
        //            else
        //            {
        //                Console.WriteLine("\nSorry, you don't have enough money available to buy that many lemons at this time.\n");
        //                SelectNumberOfLemonsToBuy();
        //            }
        //            break;

        //        default:
        //            Console.Write("\nPlease enter a valid answer.\n");
        //            SelectNumberOfLemonsToBuy();
        //            break;
        //    }
        //}

        //public void SelectCupsOfSugarToBuy()
        //{
        //    string playerInputAsString = Console.ReadLine();
        //    int playerInputAsInt = Convert.ToInt32(playerInputAsString);
        //    decimal costOfPurchase = playerInputAsInt * 0.20m;
        //    switch (playerInputAsInt)
        //    {
        //        case (0):
        //            Console.WriteLine("\nAlright, next item.\n");
        //            break;
        //        case (5):
        //        case (10):
        //        case (25):
        //        case (50):
        //        case (100):
        //            if (player.cashBox.CheckIfEnoughCash(costOfPurchase))
        //            {
        //                for (int buyQauntity = 0; buyQauntity < playerInputAsInt; buyQauntity++)
        //                sellSugar();
        //            }
        //            else
        //            {
        //                Console.WriteLine("\nSorry, you don't have enough money available to buy that many cups of sugar at this time.\n");
        //                SelectCupsOfSugarToBuy();
        //            }
        //            break;

        //        default:
        //            Console.Write("\nPlease enter a valid answer.\n");
        //            SelectCupsOfSugarToBuy();
        //            break;
        //    }
        //}

        //public void SelectNumberOfIceCubesToBuy()
        //{
        //    string playerInputAsString = Console.ReadLine();
        //    int playerInputAsInt = Convert.ToInt32(playerInputAsString);
        //    decimal costOfPurchase = playerInputAsInt * 1.00m;
        //    switch (playerInputAsInt)
        //    {
        //        case (0):
        //            Console.WriteLine("\nAlright, next item.\n");
        //            break;

        //        case (1):
        //        case (3):
        //        case (5):
        //        case (7):
        //        case (9):
        //            if (player.cashBox.CheckIfEnoughCash(costOfPurchase))
        //            {
        //                for (int buyQauntity = 0; buyQauntity < playerInputAsInt * 100; buyQauntity++)
        //                    sellIce();
        //            }
        //            else
        //            {
        //                Console.WriteLine("\nSorry, you don't have enough money available to buy that many bags of ice at this time.\n");
        //                SelectNumberOfIceCubesToBuy();
        //            }
        //            break;

        //        default:
        //            Console.Write("\nPlease enter a valid answer.\n");
        //            SelectNumberOfIceCubesToBuy();
        //            break;
        //    }
        ////}

        //public void sellCup()
        //{
        //    player.cashBox.PayForItems(0.05m);
        //    player.inventory.AddCupToInventory();
        //}

        //public void sellLemon()
        //{
        //    player.cashBox.PayForItems(0.25m);
        //    player.inventory.AddLemonToInventory();
        //}

        //public void sellSugar()
        //{
        //    player.cashBox.PayForItems(0.20m);
        //    player.inventory.AddSugarToInventory();
        //}

        //public void sellIce()
        //{
        //    player.cashBox.PayForItems(0.01m);
        //    player.inventory.AddIceToInventory();
        //}
//    }
//}
