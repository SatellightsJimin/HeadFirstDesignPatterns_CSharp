using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator_Pattern
{
    abstract class CondimentDecorator : Beverage
    {
        public abstract override string getDescription();
       
    }
}
