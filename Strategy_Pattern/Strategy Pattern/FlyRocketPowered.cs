using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy_Pattern
{
    class FlyRocketPowered : FlyBehavior
    {
        public void fly()
        {
            Console.Write("I'm flying with a rocket");
        }
    }
}
