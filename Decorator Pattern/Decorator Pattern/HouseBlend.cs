using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator_Pattern
{
    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }

        public override double cost()
        {
            return .89;
        }
    }
}
