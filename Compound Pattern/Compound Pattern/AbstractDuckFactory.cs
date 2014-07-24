using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_Pattern
{
    public abstract class AbstractDuckFactory
    {
        public abstract Quackable createMallardDuck();
        public abstract Quackable createRedheadDuck();
        public abstract Quackable createDuckCall();
        public abstract Quackable createRubberDuck();
    }
}
