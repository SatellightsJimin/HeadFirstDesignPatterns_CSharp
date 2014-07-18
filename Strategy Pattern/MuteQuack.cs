using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy_Pattern
{
    class MuteQuack :Quack
    {
        public void quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}
