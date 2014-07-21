using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    class TVOffCommand : Command
    {
        TV tv;

        public TVOffCommand(TV tv)
        {
            this.tv = tv;
        }

        public void execute()
        {
            tv.off();
        }

        public void undo()
        {
            tv.on();
        }
    }
}
