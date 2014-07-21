using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    class DuckAdapter
    {
        Duck duck;
        Random rand;

        public DuckAdapter(Duck duck)
        {
            this.duck = duck;
            rand = new Random();
        }

        public void gobble()
        {
            duck.quack();
        }

        public void fly()
        {
            if (rand.Next(5) == 0)
            {
                duck.fly();
            }
        }
    }
}
