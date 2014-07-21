using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    class Hottub
    {
        bool _on;
        int temperature;

        public Hottub()
        {
        }

        public void on()
        {
            _on = true;
        }

        public void off()
        {
            _on = false;
        }

        public void circulate()
        {
            if (_on)
            {
                Console.WriteLine("Hottub is bubbling!");
            }
        }

        public void jetsOn()
        {
            if (_on)
            {
                Console.WriteLine("Hottub jets are on");
            }
        }

        public void jetsOff()
        {
            if (_on)
            {
                Console.WriteLine("Hottub jets are off");
            }
        }

        public void setTemperature(int temperature)
        {
            if (temperature > this.temperature)
            {
                Console.WriteLine("Hottub is heating to a steaming " + temperature + " degrees");
            }
            else
            {
                Console.WriteLine("Hottub is cooling to " + temperature + " degrees");
            }
            this.temperature = temperature;
        }
    }
}
