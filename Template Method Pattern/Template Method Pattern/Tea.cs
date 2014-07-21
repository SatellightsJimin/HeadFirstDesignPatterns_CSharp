using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template_Method_Pattern
{
    class Tea : CaffeineBeverage
    {
        override public void brew()
        {
            Console.WriteLine("Steeping the tea");
        }
        override public void addCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }
    }
}
