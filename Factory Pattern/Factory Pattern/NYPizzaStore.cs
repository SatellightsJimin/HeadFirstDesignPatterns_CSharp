using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    class NYPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string item)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory =
                new NYPizzaIngredientFactory();

            if (item=="cheese")
            {

                pizza = new CheesePizza(ingredientFactory);
                pizza.setName("New York Style Cheese Pizza");

            }
            else if (item=="veggie")
            {

                pizza = new VeggiePizza(ingredientFactory);
                pizza.setName("New York Style Veggie Pizza");

            }
            else if (item=="clam")
            {

                pizza = new ClamPizza(ingredientFactory);
                pizza.setName("New York Style Clam Pizza");

            }
            else if (item=="pepperoni")
            {

                pizza = new PepperoniPizza(ingredientFactory);
                pizza.setName("New York Style Pepperoni Pizza");

            }
            return pizza;
        }
    }
}
