using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator_Pattern
{
    class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast Coffee";
        }

        public override double cost()
        {
            return .99;
        }
    }
}
