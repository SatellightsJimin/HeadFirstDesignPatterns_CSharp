﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    class LightOffCommand : Command
    {
        Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void execute()
        {
            light.off();
        }

        public void undo()
        {
            light.on();
        }
    }
}
