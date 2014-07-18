using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy_Pattern
{
    class FlyWithWings : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying!!");
        }
    }
}
