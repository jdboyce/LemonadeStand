using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Pitcher
    {
        public LemonadeStand lemonadeStand;
        public CupOfLemonade cupOfLemonade;

        public int qualityOfLemonade;
        public int lemonsInPitcher;
        public int cupsOfSugarInPitcher;
        public int iceCubesInPitcher;


        public Pitcher(LemonadeStand passedLemonadeStand, int lemonsPerPitcher, int cupsOfSugarPerPitcher, int iceCubesPerPitcher)
        {
            this.lemonsInPitcher = lemonsPerPitcher;
            this.cupsOfSugarInPitcher = cupsOfSugarPerPitcher;
            this.iceCubesInPitcher = iceCubesPerPitcher;
            this.lemonadeStand = passedLemonadeStand;
        }

        public void PourCupsfLemonade()
        {
            for (int cupsPoured = 0; cupsPoured < 20; cupsPoured++)
                lemonadeStand.AddCupOfLemonade();
        }


        public int DetermineQualityOfLemonade()
        {
            qualityOfLemonade = 120;
            CheckLemonAmount();
            CheckSugarAmount();
            CheckIceAmount();
            return qualityOfLemonade;
        }

        public void CheckLemonAmount()
        {
            if (lemonsInPitcher < 5)
                for (int tooFewLemons = lemonsInPitcher; tooFewLemons < 5; tooFewLemons++)
                    qualityOfLemonade -= 10;
            else if (lemonsInPitcher > 5)
                for (int tooManyLemons = lemonsInPitcher; tooManyLemons > 5; tooManyLemons--)
                    qualityOfLemonade -= 10;
        }



        public void CheckSugarAmount()
        {
            if (cupsOfSugarInPitcher < 6)
                for (int tooLittleSugar = cupsOfSugarInPitcher; tooLittleSugar < 6; tooLittleSugar++)
                    qualityOfLemonade -= 10;
            else if (cupsOfSugarInPitcher > 6)
                for (int tooMuchSugar = cupsOfSugarInPitcher; tooMuchSugar > 6; tooMuchSugar--)
                    qualityOfLemonade -= 10;
        }


        public void CheckIceAmount()
        {
            int iceCubesPerCup = iceCubesInPitcher / 20;
            if (iceCubesPerCup < 5)
                for (int tooLittleIce = iceCubesPerCup; tooLittleIce < 5; tooLittleIce++)
                    qualityOfLemonade -= 10;
            else if (iceCubesPerCup > 5)
                for (int tooMuchIce = iceCubesPerCup; tooMuchIce > 5; tooMuchIce--)
                    qualityOfLemonade -= 10;
        }
    }
}
