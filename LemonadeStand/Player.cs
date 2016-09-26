using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Player
    {

        public CashBox cashBox;
        public Inventory inventory;
        public Kitchen kitchen;
        public LemonadeStand lemonadeStand;


        public Player()
        {
            cashBox = new CashBox();
            inventory = new Inventory();
            lemonadeStand = new LemonadeStand();
            kitchen = new Kitchen(inventory, lemonadeStand);
        }





    }
}
