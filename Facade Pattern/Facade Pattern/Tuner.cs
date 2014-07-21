using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade_Pattern
{
    class Tuner
    {
        String description;
        Amplifier amplifier;
        double frequency;

        public Tuner(String description, Amplifier amplifier)
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

        public void setFrequency(double frequency)
        {
            Console.WriteLine(description + " setting frequency to " + frequency);
            this.frequency = frequency;
        }

        public void setAm()
        {
            Console.WriteLine(description + " setting AM mode");
        }

        public void setFm()
        {
            Console.WriteLine(description + " setting FM mode");
        }

        public String toString()
        {
            return description;
        }
    }
}
