using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_Pattern
{
    class GooseAdapter : Quackable
    {
        Goose goose;
        public GooseAdapter(Goose goose)
        {
            this.goose = goose;
        }
        public void quack()
        {
            goose.honk();
        }
    }
}
