using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class BagOfLemons : Item
    {

        public BagOfLemons()
        {
            name = "lemons";

            cost = 1.25m;

            contains = "5 lemons";

            units = 5;
        }
             

    }
}
