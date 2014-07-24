using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_Pattern
{
    class Flock : Quackable
    {
        ArrayList quackers = new ArrayList();
        public void add(Quackable quacker)
        {
            quackers.Add(quacker);
        }

        public void quack()
        {
            foreach (Quackable quacker in quackers)
            {
                quacker.quack();
            }
        }
    }
}
