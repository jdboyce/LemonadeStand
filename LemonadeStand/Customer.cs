using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Customer
    {
        public Player player;

        public int positiveInfluencingFactors;
        public int resistanceToPurchase;

        public List<CupOfLemonade> customersLemonade;

        Random randomNumber = new Random();

        public Customer(Player passedPlayer, int positiveInfluencingFactors)
        {
            this.player = passedPlayer;
            this.positiveInfluencingFactors = positiveInfluencingFactors;
            customersLemonade = new List<CupOfLemonade>();
        }


        public void CheckInterestInBuying()
        {
            resistanceToPurchase = randomNumber.Next(310, 330);
            if (positiveInfluencingFactors >= resistanceToPurchase)
                BuyLemonade();
        }


        public void BuyLemonade()
        {
            player.cashBox.ReceiveCashFromSale(player.lemonadeStand.costPerCup);
            CupOfLemonade cup = new CupOfLemonade();
            customersLemonade.Add(cup);
        }
    }
}
