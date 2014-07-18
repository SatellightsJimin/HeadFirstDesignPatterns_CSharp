using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator_Pattern
{
    abstract class Beverage
    {
        protected string description = "";

        public virtual string getDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}
