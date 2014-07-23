using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator_Pattern
{
    class Waitress
    {
        private PancakeHouseMenu pancakeHouseMenu;
        private DinerMenu dinerMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            // TODO: Complete member initialization
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
        }

        internal void printMenu()
        {
            Iterator pancakeIterator = pancakeHouseMenu.createIterator();
            Iterator dinerIterator = dinerMenu.createIterator();

            Console.WriteLine("MENU\n----\n점심");
            printMenu(pancakeIterator);
            Console.WriteLine("\n저녁");
            printMenu(dinerIterator);
        }

        private void printMenu(Iterator iterator)
        {
            while (iterator.hasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.next();
                Console.Write(menuItem.getName() + ", ");
                Console.WriteLine(menuItem.getPrice() + " -- ");
                Console.WriteLine(menuItem.getDescription());
            }
        }

        public void printVegetarianMenu()
        {
            printVegetarianMenu(pancakeHouseMenu.createIterator());
            printVegetarianMenu(dinerMenu.createIterator());
        }

        public bool isItemVegetarian(string name)
        {
            Iterator breakfastIterator = pancakeHouseMenu.createIterator();
            if (isVegetarian(name, breakfastIterator))
            {
                return true;
            }
            Iterator dinnerIterator = dinerMenu.createIterator();
            if (isVegetarian(name, dinnerIterator))
            {
                return true;
            }
            return false;
        }

        private bool isVegetarian(string name, Iterator iterator)
        {
            while (iterator.hasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.next();
                if (menuItem.getName().Equals(name))
                {
                    if (menuItem.isVegetarian())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void printVegetarianMenu(Iterator iterator)
        {
            while (iterator.hasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.next();
                if (menuItem.isVegetarian())
                {
                    Console.Write(menuItem.getName());
                    Console.WriteLine("\t\t" + menuItem.getPrice());
                    Console.WriteLine("\t" + menuItem.getDescription());
                }
            }
        }
    }
}
