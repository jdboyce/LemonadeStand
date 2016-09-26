using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Weather
    {
        public int temperature;

        public string weatherForecast;
        public int weatherForecastAsInt;
        public int conditionsInfluencingCustomer;

        Random randomNumber = new Random();

        public void CreateWeather()
        {
            temperature = randomNumber.Next(65, 81);
            weatherForecastAsInt = randomNumber.Next(1, 6);

            if (weatherForecastAsInt == 5)
            {
                weatherForecast = "Sunny";
            }
            else if (weatherForecastAsInt == 4)
            {
                weatherForecast = "Hazy";
            }
            else if (weatherForecastAsInt == 3)
            {
                weatherForecast = "Cloudy";
            }
            else if (weatherForecastAsInt == 2)
            {
                weatherForecast = "Overcast";
            }
            else if (weatherForecastAsInt == 1)
            {
                weatherForecast = "Rainy";
            }
        }


        public void DetermineQaulityOfWeather()
        {
            conditionsInfluencingCustomer = 0;
            conditionsInfluencingCustomer += temperature / 2 + 30;
            conditionsInfluencingCustomer += weatherForecastAsInt * 10 + 10;
        }
    }
}
