using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class LemonadeStand
    {

        public List<CupOfLemonade> cupsForSale;

        public CupOfLemonade cupOfLemonade;

        public decimal costPerCup;


        public void AddCupOfLemonade()
        {
            cupsForSale.Add(cupOfLemonade);
        }

        public void SellCupOfLemonade()
        {
            cupsForSale.Remove(cupOfLemonade);
        }


        //public void ChoosePrice()
        //{
        //    Console.WriteLine("\nNow it's time to choose a price for your lemonade. How many cents do you wany to charge per cup?");
        //    string priceAsString = Console.ReadLine();
        //    costPerCup = Convert.ToDecimal(priceAsString) / 100;
        //}


        public void ChoosePrice()
        {
            Console.Write("\n Time to price the lemonade. How many cents do you want to charge per cup? ");
            string choosePrice = Console.ReadLine();
            decimal price = Convert.ToDecimal(choosePrice);
            costPerCup = price;
            Console.Write("\n You will charge ${0} per cup.", costPerCup);
            Console.ReadLine();
        }

    }
}
