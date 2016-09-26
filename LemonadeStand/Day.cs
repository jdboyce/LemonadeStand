using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Day
    {
        public Player player;
        public Store store;
        public Weather weather;

        public List<Customer> customers;

        public int dayNumber;
        public int pricePerCupOfLemonade;
        public int positiveInfluencingFactors;

        public Day(Player player, int dayNumber)
        {
            this.player = player;
            this.dayNumber = dayNumber;
            weather = new Weather();
            store = new Store(player, weather, dayNumber);
            customers = new List<Customer>();
        }


        //public void DisplayStatus()
        //{
        //    // http://www.messletters.com/en/big-text/

        //    Console.ForegroundColor = ConsoleColor.Yellow;
        //    Console.WriteLine(@" __    ___  __  __   __   _  _   __   ___   ___");
        //    Console.WriteLine(@"(  )  (  _)(  \/  ) /  \ ( \( ) (  ) (   \ (  _)");
        //    Console.ForegroundColor = ConsoleColor.White;
        //    Console.WriteLine(@" )(__  ) _) )    ( ( () ) )  (  /__\  ) ) ) ) _)");
        //    Console.ForegroundColor = ConsoleColor.Yellow;
        //    Console.WriteLine(@"(____)(___)(_/\/\_) \__/ (_)\_)(_)(_)(___/ (___)");

        //    Console.WriteLine(@" ___  ____   __   _  _  ___  ");
        //    Console.WriteLine(@"/ __)(_  _) (  ) ( \( )(   \ ");
        //    Console.ForegroundColor = ConsoleColor.White;
        //    Console.WriteLine(@"\__ \  )(   /__\  )  (  ) ) )");
        //    Console.ForegroundColor = ConsoleColor.Yellow;

        //    Console.WriteLine(@"(___/ (__) (_)(_)(_)\_)(___/ ");

        //}

        public void RunDayTimeline()
        {
            weather.CreateWeather();
            store.GoShopping();
            player.kitchen.ChooseRecipe();
            player.kitchen.ChooseNumberOfPitchers();
            player.lemonadeStand.ChoosePrice();
            Console.WriteLine("\n Okay, time to sell!\n");
            CreateCustomers();
            CalculateInfluencingFactors();
            OfferLemonadeToCustomers();
            EndOfDayReport();
            InventoryLoss();
        }

        public void DisplayInventory()
        {

        }


        public void CalculateInfluencingFactors()
        {
            int costPerCup = Convert.ToInt32(player.lemonadeStand.costPerCup * 100);
            positiveInfluencingFactors = 200;
            positiveInfluencingFactors -= costPerCup * 2;
            positiveInfluencingFactors += player.kitchen.pitcher.qualityOfLemonade;
            positiveInfluencingFactors += weather.conditionsInfluencingCustomer;
        }


        public void CreateCustomers()
        {
            for (int newCustomer = 0; newCustomer < weather.conditionsInfluencingCustomer; newCustomer++)
            {
                Customer customer = new Customer(player, positiveInfluencingFactors);
                customers.Add(customer);
            }
        }


        public void OfferLemonadeToCustomers()
        {
            for (int shoppingCustomer = 0; shoppingCustomer < customers.Count(); shoppingCustomer++)
            {
                customers[shoppingCustomer].CheckInterestInBuying();
            }
        }



        public void EndOfDayReport()
        {
            // Review
            // Total Number of Sales Per Potential Customers
            // Customer Satisfaction
            // Your Popularity

            InventoryLoss();
        }


        public void InventoryLoss()
        {
            // Ice Melts
            // Lemons Go Bad
            // Sugar Gets Bugs

            // While (dayNumber)

            // New Day

            dayNumber++;
        }
    }
}
