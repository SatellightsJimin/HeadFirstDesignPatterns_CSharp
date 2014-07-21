using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    class TVOnCommand : Command
    {
        TV tv;

        public TVOnCommand(TV tv)
        {
            this.tv = tv;
        }

        public void execute()
        {
            tv.on();
            tv.setInputChannel();
        }

        public void undo()
        {
            tv.off();
        }
    }
}
