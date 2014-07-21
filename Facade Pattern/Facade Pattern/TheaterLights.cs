using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade_Pattern
{
    class TheaterLights
    {
        String description;

        public TheaterLights(String description)
        {
            this.description = description;
        }

        public void on()
        {
            Console.WriteLine(description + " on");
        }

        public void off()
        {
            Console.WriteLine(description + " off");
        }

        public void dim(int level)
        {
            Console.WriteLine(description + " dimming to " + level + "%");
        }

        public String toString()
        {
            return description;
        }
    }
}
