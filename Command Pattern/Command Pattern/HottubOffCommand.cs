using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    class HottubOffCommand : Command
    {
        Hottub hottub;

        public HottubOffCommand(Hottub hottub)
        {
            this.hottub = hottub;
        }

        public void execute()
        {
            hottub.setTemperature(98);
            hottub.off();
        }
        public void undo()
        {
            hottub.on();
        }
    }
}
