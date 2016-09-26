using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class BagOfIce : Item
    {
        public BagOfIce()
        {
            name = "ice";

            cost = 1.00m;

            contains = "100 ice cubes";

            units = 100;
        }
    }
}
