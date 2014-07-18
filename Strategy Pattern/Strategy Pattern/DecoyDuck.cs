using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy_Pattern
{
    class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            setFlyBehavior(new FlyNoWay());
            setQuackBehavior(new MuteQuack());
        }
        public override void display() 
        {
		    Console.WriteLine("I'm a duck Decoy");
	    }
    }
}
