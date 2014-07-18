using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer_Pattern
{
    interface Observer
    {
        void update(float temp, float humidity, float pressure);
    }
}
