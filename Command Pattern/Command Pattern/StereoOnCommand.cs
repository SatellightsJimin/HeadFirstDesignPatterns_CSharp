using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    class StereoOnCommand : Command
    {
        Stereo stereo;

        public StereoOnCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void execute()
        {
            stereo.on();
        }

        public void undo()
        {
            stereo.off();
        }
    }
}
