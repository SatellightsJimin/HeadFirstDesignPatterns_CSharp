using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Pattern
{
    abstract class CaffeineBaverageWithHook
    {
        public void prepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            if (customerWantsCondiments())
            {
                addCondiments();
            }
        }

        abstract public void brew();

        abstract public void addCondiments();

        void boilWater() {
		Console.WriteLine("Boiling water");
	}

        void pourInCup() {
		Console.WriteLine("Pouring into cup");
	}

        bool customerWantsCondiments()
        {
            return true;
        }
    }
}
