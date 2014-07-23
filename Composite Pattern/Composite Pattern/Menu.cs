using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    public class Menu : MenuComponent
    {
        ArrayList menuComponents = new ArrayList();
        string name;
        string description;

        public Menu(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public override void add(MenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }

        public override void remove(MenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }
        public override MenuComponent getChild(int i)
        {
            return (MenuComponent)menuComponents[i];
        }
        public override string getName()
        {
            return name;
        }
        public override string getDescription()
        {
            return description;
        }
        public override void print()
        {
            Console.Write("\n" + getName());
            Console.WriteLine(", " + getDescription());
            Console.WriteLine("---------------------");
            foreach (MenuComponent menuComponent in menuComponents)
            {
                menuComponent.print();
            }
        }
    }
}
