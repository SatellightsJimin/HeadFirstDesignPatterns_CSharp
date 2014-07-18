using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy_Pattern
{
    class FlyNoWay :FlyBehavior
    {
        public void fly() 
        {
		    Console.WriteLine("I can't fly");
	    }
    }
}
