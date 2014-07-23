﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    class PancakeHouseMenu : Menu
    {
        ArrayList menuItems;
        public PancakeHouseMenu()
        {
            menuItems = new ArrayList();
            addItem("K&B's Pancake Breakfast",
            "Pancakes with scrambled eggs, and toast",
            true,
            2.99);

            addItem("Regular Pancake Breakfast",
                "Pancakes with fried eggs, sausage",
                false,
                2.99);

            addItem("Blueberry Pancakes",
                "Pancakes made with fresh blueberries",
                true,
                3.49);

            addItem("Waffles",
                "Waffles, with your choice of blueberries or strawberries",
                true,
                3.59);
        }

        private void addItem(string name, string description,
                        bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem);
        }

        public ArrayList getMenuItems()
        {
            return menuItems;
        }
        public override string ToString()
        {
            return "Objectville Pancake House Menu";
        }
        public Iterator createIterator()
        {
            return new PancakeHouseMenuIterator(menuItems);
        }
    }
}
