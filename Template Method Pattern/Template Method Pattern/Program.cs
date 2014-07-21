using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Tea tea = new Tea();
		    Coffee coffee = new Coffee();
 
		    Console.WriteLine("\nMaking tea...");
		    tea.prepareRecipe();
 
		    Console.WriteLine("\nMaking coffee...");
		    coffee.prepareRecipe();

 
		    TeaWithHook teaHook = new TeaWithHook();
		    CoffeeWithHook coffeeHook = new CoffeeWithHook();
 
		    Console.WriteLine("\nMaking tea...");
		    teaHook.prepareRecipe();
 
		    Console.WriteLine("\nMaking coffee...");
		    coffeeHook.prepareRecipe();

        }
    }
}
