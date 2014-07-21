using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    class Stereo
    {
        String location;

        public Stereo(String location)
        {
            this.location = location;
        }

        public void on()
        {
            Console.WriteLine(location + " stereo is on");
        }

        public void off()
        {
            Console.WriteLine(location + " stereo is off");
        }

        public void setCD()
        {
            Console.WriteLine(location + " stereo is set for CD input");
        }

        public void setDVD()
        {
            Console.WriteLine(location + " stereo is set for DVD input");
        }

        public void setRadio()
        {
            Console.WriteLine(location + " stereo is set for Radio");
        }

        public void setVolume(int volume)
        {
            Console.WriteLine(location + " Stereo volume set to " + volume);
        }
    }
}
