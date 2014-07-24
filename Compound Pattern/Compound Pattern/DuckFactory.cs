using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_Pattern
{
    class DuckFactory : AbstractDuckFactory
    {
        public override Quackable createMallardDuck()
        {
            return new MallardDuck();
        }

        public override Quackable createRedheadDuck()
        {
            return new RedHeadDuck();
        }

        public override Quackable createDuckCall()
        {
            return new DuckCall();
        }

        public override Quackable createRubberDuck()
        {
            return new RubberDuck();
        }
    }
}
