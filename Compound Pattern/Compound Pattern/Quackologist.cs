using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_Pattern
{
    class Quackologist : Observer
    {
        public void update(QuackObservable duck)
        {
            Console.WriteLine("Quackologist :" + duck.ToString() + " just quacked.");
        }
    }
}
