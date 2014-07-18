﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.orderPizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza + "\n");

            pizza = chicagoStore.orderPizza("cheese");
            Console.WriteLine("Joel ordered a " + pizza + "\n");

            pizza = nyStore.orderPizza("clam");
            Console.WriteLine("Ethan ordered a " + pizza + "\n");

            pizza = chicagoStore.orderPizza("clam");
            Console.WriteLine("Joel ordered a " + pizza + "\n");

            pizza = nyStore.orderPizza("pepperoni");
            Console.WriteLine("Ethan ordered a " + pizza + "\n");

            pizza = chicagoStore.orderPizza("pepperoni");
            Console.WriteLine("Joel ordered a " + pizza + "\n");

            pizza = nyStore.orderPizza("veggie");
            Console.WriteLine("Ethan ordered a " + pizza + "\n");

            pizza = chicagoStore.orderPizza("veggie");
            Console.WriteLine("Joel ordered a " + pizza + "\n");

            
        }
    }
}
