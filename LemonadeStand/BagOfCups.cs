using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class BagOfCups : Item
    {
        public BagOfCups()
        {
            name = "cups";

            cost = 1.00m;

            contains = "20 cups";

            units = 20;
        }
    }
}
