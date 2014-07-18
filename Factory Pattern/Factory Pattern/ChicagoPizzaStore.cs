using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Pattern
{
    class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string item)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory =
                new ChicagoPizzaIngredientFactory();

            if (item == "cheese")
            {

                pizza = new CheesePizza(ingredientFactory);
                pizza.setName("Chicago Style Cheese Pizza");

            }
            else if (item == "veggie")
            {

                pizza = new VeggiePizza(ingredientFactory);
                pizza.setName("Chicago Style Veggie Pizza");

            }
            else if (item == "clam")
            {

                pizza = new ClamPizza(ingredientFactory);
                pizza.setName("Chicago Style Clam Pizza");

            }
            else if (item == "pepperoni")
            {

                pizza = new PepperoniPizza(ingredientFactory);
                pizza.setName("Chicago Style Pepperoni Pizza");

            }
            return pizza;
        }
    }
}
