using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Inventory
    {

        public List<Cup> cupsInStock;
        public List<Lemon> lemonsInStock;
        public List<Sugar> cupsOfSugarInStock;
        public List<Ice> iceCubesInStock;

        Cup cup;
        Lemon lemon;
        Sugar sugar;
        Ice ice;

        public Inventory()
        {
            cupsInStock = new List<Cup>();
            lemonsInStock = new List<Lemon>();
            cupsOfSugarInStock = new List<Sugar>();
            iceCubesInStock = new List<Ice>();

            cup = new Cup();
            lemon = new Lemon();
            sugar = new Sugar();
            ice = new Ice();

        }











        public void AddItemsToInventory(string passedItemType)
        {
            switch (passedItemType)
            {
                case ("cups"):
                    for (int i = 0; i < 20; i++)
                    {
                        cupsInStock.Add(cup);
                    }
                    break;
                case ("lemons"):
                    for (int i = 0; i < 5; i++)
                    {
                        lemonsInStock.Add(lemon);
                    }
                    break;
                case ("sugar"):
                    for (int i = 0; i < 5; i++)
                    {
                        cupsOfSugarInStock.Add(sugar);
                    }
                    break;
                case ("ice"):
                    for (int i = 0; i < 100; i++)
                    {
                        iceCubesInStock.Add(ice);
                    }
                    break;
            }
        }




        public void AddCupToInventory()
        {
            
        }


        public void AddLemonToInventory()
        {
            lemonsInStock.Add(lemon);
        }


        public void AddSugarToInventory()
        {
            cupsOfSugarInStock.Add(sugar);
        }


        public void AddIceToInventory()
        {
            iceCubesInStock.Add(ice);
        }


        public void useCup()
        {
           cupsInStock.Remove(cup);
        }


        public void useLemon()
        {
            lemonsInStock.Remove(lemon);
        }


        public void useSugar()
        {
            cupsOfSugarInStock.Remove(sugar);
        }


        public void useIce()
        {
            iceCubesInStock.Remove(ice);
        }
    }
}
