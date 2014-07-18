using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Pattern
{
    class CheesePizza : Pizza
    {
        private PizzaIngredientFactory ingredientFactory;

        public CheesePizza(PizzaIngredientFactory ingredientFactory)
        {
            // TODO: Complete member initialization
            this.ingredientFactory = ingredientFactory;
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing " + name);
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
        }
    }
}
