using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite_Pattern
{
    class Waitress
    {
        public MenuComponent allMenus;

        public Waitress(MenuComponent allMenus)
        {
            // TODO: Complete member initialization
            this.allMenus = allMenus;
        }

        public void printMenu()
        {
            allMenus.print();
        }
    }
}
