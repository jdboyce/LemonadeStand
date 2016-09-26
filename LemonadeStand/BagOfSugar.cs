using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class BagOfSugar : Item
    {
        public BagOfSugar()
        {
            name = "sugar";

            cost = 1.20m;

            contains = "6 cups of sugar";

            units = 6;
        }

    }
}
