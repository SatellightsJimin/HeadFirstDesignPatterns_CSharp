using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State_Pattern
{
    class SoldOutState : State
    {
        private GumballMachine gumBallMachine;

        public SoldOutState(GumballMachine gumBallMachine)
        {
            // TODO: Complete member initialization
            this.gumBallMachine = gumBallMachine;
        }

        public void insertQuarter()
        {
            Console.WriteLine("품절입니다");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("품절입니다");
        }

        public void turnCrank()
        {
            Console.WriteLine("품절입니다");
        }

        public void dispense()
        {
            Console.WriteLine("알맹이가 나갈 수 없습니다");
        }
        override public String ToString()
        {
            return " 품절입니다";
        }
    }
}
