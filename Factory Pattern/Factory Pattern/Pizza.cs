using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Pattern
{
    public abstract class Pizza
    {
        public string name;

        public Dough dough;
        public Sauce sauce;
        public Veggies[] veggies;
        public Cheese cheese;
        public Pepperoni pepperoni;
        public Clams clam;

        public abstract void prepare();

        public void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public override String ToString()
        {
            
            string result = "---- " + name + " ----\n";
            if (dough != null)
            {
                result += dough;
                result += "\n";
            }
            if (sauce != null)
            {
                result += sauce;
                result += "\n";
            }
            if (cheese != null)
            {
                result += cheese;
                result += "\n";
            }
            if (veggies != null)
            {
                foreach (Veggies v in veggies)
                {
                    int i = 0;
                    result += (v.ToString());
                    if (i < veggies.Length - 1)
                    {
                        result += (", ");
                    }
                    i++;
                }
                result += "\n";
            }
            if (clam != null)
            {
                result += clam;
                result += "\n";
            }
            if (pepperoni != null)
            {
                result += (pepperoni);
                result += ("\n");
            }
            return result.ToString();
        }

    }
}
