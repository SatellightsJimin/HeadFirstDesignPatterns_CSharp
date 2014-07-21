using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade_Pattern
{
    class PopcornPopper
    {
        String description;

        public PopcornPopper(String description)
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

        public void pop()
        {
            Console.WriteLine(description + " popping popcorn!");
        }


        public String toString()
        {
            return description;
        }
    }
}
