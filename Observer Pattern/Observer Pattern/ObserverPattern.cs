using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    class ObserverPattern
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionDisplay currentDisplay = new CurrentConditionDisplay(weatherData);
            StatisticsDisplay statisticDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.setMeasurements(80,65,30.4f);
            Console.WriteLine();
            weatherData.setMeasurements(82,70,29.2f);
            Console.WriteLine();
            weatherData.setMeasurements(78,90,29.2f);
            Console.WriteLine();


        }
    }
}
