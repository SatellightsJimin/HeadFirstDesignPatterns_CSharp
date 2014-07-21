using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    class HottubOnCommand :Command
    {
        Hottub hottub;

        public HottubOnCommand(Hottub hottub)
        {
            this.hottub = hottub;
        }
        public void execute()
        {
            hottub.on();
            hottub.setTemperature(104);
            hottub.circulate();
        }
        public void undo()
        {
            hottub.off();
        }
    }
}
