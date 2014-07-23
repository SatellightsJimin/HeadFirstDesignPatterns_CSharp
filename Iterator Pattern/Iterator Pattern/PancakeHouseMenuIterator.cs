using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator_Pattern
{
    class PancakeHouseMenuIterator : Iterator
    {
        ArrayList items;
        int position = 0;
       

        public PancakeHouseMenuIterator(ArrayList menuItems)
        {
            // TODO: Complete member initialization
            items = menuItems;
        }

        public bool hasNext()
        {
            if (position >= items.Count)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object next()
        {
            object obj = items[position];
            position = position +1;
            return obj;
        }
    }
}
