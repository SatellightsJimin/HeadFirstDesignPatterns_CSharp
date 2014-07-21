using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    class CommandPattern
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

		    Light light = new Light("Living Room");
		    TV tv = new TV("Living Room");
		    Stereo stereo = new Stereo("Living Room");
		    Hottub hottub = new Hottub();
 
		    LightOnCommand lightOn = new LightOnCommand(light);
		    StereoOnCommand stereoOn = new StereoOnCommand(stereo);
		    TVOnCommand tvOn = new TVOnCommand(tv);
		    HottubOnCommand hottubOn = new HottubOnCommand(hottub);
		    LightOffCommand lightOff = new LightOffCommand(light);
		    StereoOffCommand stereoOff = new StereoOffCommand(stereo);
		    TVOffCommand tvOff = new TVOffCommand(tv);
		    HottubOffCommand hottubOff = new HottubOffCommand(hottub);

    		Command[] partyOn = { lightOn, stereoOn, tvOn, hottubOn};
		    Command[] partyOff = { lightOff, stereoOff, tvOff, hottubOff};
  
    		MacroCommand partyOnMacro = new MacroCommand(partyOn);
		    MacroCommand partyOffMacro = new MacroCommand(partyOff);
     
		    remoteControl.setCommand(0, partyOnMacro, partyOffMacro);
      
		    Console.WriteLine(remoteControl);
		    Console.WriteLine("--- Pushing Macro On---");
		    remoteControl.onButtonWasPushed(0);
		    Console.WriteLine("--- Pushing Macro Off---");
		    remoteControl.offButtonWasPushed(0);
       }
    }
}
