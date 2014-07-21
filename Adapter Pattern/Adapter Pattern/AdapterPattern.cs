using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    class AdapterPattern
    {
        static void Main(string[] args)
        {
            MallardDuck duck = new MallardDuck();
 
		    WildTurkey turkey = new WildTurkey();
		    Duck turkeyAdapter = new TurkeyAdapter(turkey);
   
    		Console.WriteLine("The Turkey says...");
		    turkey.gobble();
		    turkey.fly();
 
    		Console.WriteLine("\nThe Duck says...");
	    	testDuck(duck);
  
		    Console.WriteLine("\nThe TurkeyAdapter says...");
		    testDuck(turkeyAdapter);
	    }
 
	    static void testDuck(Duck duck) {
		    duck.quack();
		    duck.fly();
	    }
        
    }
}
