using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Pattern
{
    abstract public class CaffeineBeverage
    {
        public void prepareRecipe(){
            boilWater();
            brew();
            pourInCup();
            addCondiments();
        }

        abstract public void brew();
        abstract public void addCondiments();

        protected void boilWater()
        {
            Console.WriteLine("Boiling water");
        }

        protected void pourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
}
