using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    class StereoOffCommand : Command
    {
        Stereo stereo;

        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void execute()
        {
            stereo.off();
        }

        public void undo()
        {
            stereo.on();
        }
    }
}
