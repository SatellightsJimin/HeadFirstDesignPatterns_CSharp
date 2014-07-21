using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template_Method_Pattern
{
    class TeaWithHook : CaffeineBaverageWithHook
    {
        override public void brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        override public void addCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        public bool customerWantsCondiments()
        {

            string answer = getUserInput();

            if (answer.ToLower().StartsWith("y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string getUserInput() {
		// get the user's response
		string answer = null;

		Console.Write("Would you like lemon with your tea (y/n)? ");

		try {
			answer = Console.ReadLine();
		} catch (Exception e) {
		    Console.WriteLine("IO error trying to read your answer");
		}
		if (answer == null) {
			return "no";
		}
		return answer;
	}
    }
}
