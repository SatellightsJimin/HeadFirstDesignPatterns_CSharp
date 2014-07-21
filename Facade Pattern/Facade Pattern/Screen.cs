using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade_Pattern
{
    class Screen
    {
        String description;

        public Screen(String description)
        {
            this.description = description;
        }

        public void up()
        {
            Console.WriteLine(description + " going up");
        }

        public void down()
        {
            Console.WriteLine(description + " going down");
        }


        public String toString()
        {
            return description;
        }
    }
}
