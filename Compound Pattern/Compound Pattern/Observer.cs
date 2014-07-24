using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compound_Pattern
{
    public interface Observer
    {
        void update(QuackObservable duck);
    }
}
