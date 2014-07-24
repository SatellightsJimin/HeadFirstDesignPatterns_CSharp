using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_Pattern
{
    class CountingDuckFactory : AbstractDuckFactory
    {

        public override Quackable createMallardDuck()
        {
            return new QuackCounter(new MallardDuck());
        }

        public override Quackable createRedheadDuck()
        {
            return new QuackCounter(new RedHeadDuck());
        }

        public override Quackable createDuckCall()
        {
            return new QuackCounter(new DuckCall());
        }

        public override Quackable createRubberDuck()
        {
            return new QuackCounter(new RubberDuck());
        }
    }
}
