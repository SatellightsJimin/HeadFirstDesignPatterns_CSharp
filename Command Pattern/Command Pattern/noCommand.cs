using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    class NoCommand : Command
    {
        public void execute()
        {
        }

        public void undo()
        {
        }
    }
}
