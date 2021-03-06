﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer_Pattern
{
    class ForecastDisplay : Observer, DisplayElement
    {
        private float currentPressure = 29.92f;
        private float lastPressure;
        private WeatherData weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            // TODO: Complete member initialization
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void update(float temp, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;
            display();
        }

        public void display()
        {
            Console.WriteLine("Forecast: ");
		    if (currentPressure > lastPressure) 
            {
			    Console.WriteLine("Improving weather on the way!");
		    } else if (currentPressure == lastPressure) 
            {
			    Console.WriteLine("More of the same");
		    } else if (currentPressure < lastPressure) 
            {
            Console.WriteLine("Watch out for cooler, rainy weather");
		    }
        }
    }
}
