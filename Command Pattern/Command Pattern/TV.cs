using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    class TV
    {
        string location;
        int channel;

        public TV(String location)
        {
            this.location = location;
        }

        public void on() {
		Console.WriteLine(location + " TV is on");
	}

        public void off() {
		Console.WriteLine(location + " TV is off");
	}

        public void setInputChannel() {
		this.channel = 3;
		Console.WriteLine(location + " TV channel is set for DVD");
	}
    }
}
