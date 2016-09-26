using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class CashBox
    {
        public decimal cashOnHand /*= 25.00m*/; // Starting: $25.00

        public CashBox()
        {
            cashOnHand = 25.00m;
        }

        public bool CheckIfEnoughCash(decimal amountRequested)
        {
            if (amountRequested <= cashOnHand)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public decimal PayForItems(decimal passedCost)
        {
            return cashOnHand -= passedCost;
        }

        public decimal ReceiveCashFromSale(decimal passedSale)
        {
            return cashOnHand += passedSale;
        }
    }
}
