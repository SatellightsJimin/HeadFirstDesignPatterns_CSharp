﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator_Pattern
{
    class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public override double cost()
        {
            return 1.99;
        }
    }
}
