using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    class MacroCommand : Command
    {
        Command[] commands;

        public MacroCommand(Command[] commands)
        {
            this.commands = commands;
        }

        public void execute()
        {
            for (int i = 0; i < commands.Length; i++)
            {
                commands[i].execute();
            }
        }

        public void undo()
        {
            for (int i = commands.Length - 1; i >= 0; i--)
            {
                commands[i].undo();
            }
        }
    }
}
