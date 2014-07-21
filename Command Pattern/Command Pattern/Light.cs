using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    class Light
    {
        string location;
        int level;

        public Light(string location)
        {
            this.location = location;
        }

        public void on()
        {
            level = 100;
            Console.WriteLine("Light is on");
        }

        public void off()
        {
            level = 0;
            Console.WriteLine("Light is off");
        }

        public void dim(int level)
        {
            this.level = level;
            if (level == 0)
            {
                off();
            }
            else
            {
                Console.WriteLine("Light is dimmed to " + level + "%");
            }
        }
        public int getLevel(){
            return level;
        }
        
    }
}
