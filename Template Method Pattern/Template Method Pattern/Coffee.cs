using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template_Method_Pattern
{
    class Coffee : CaffeineBeverage
    {
        override public void brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }
        override public void addCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }
    }
}
