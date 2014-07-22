using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    
    class NoQuarterState : State
    {
        GumballMachine gumballMachine;
  

        public NoQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

       
        public void insertQuarter()
        {
            Console.WriteLine("동전을 넣으셨습니다");
            gumballMachine.setState(gumballMachine.getHasQuarterState());
        }

        public void ejectQuarter()
        {
            Console.WriteLine("동전을 넣지 않았습니다");
        }

        public void turnCrank()
        {
            Console.WriteLine("레버를 돌렸지만 동전이 없습니다");
        }

        public void dispense()
        {
            Console.WriteLine("먼저 동전을 넣어야 합니다");
        }
        override public String ToString()
        {
            return " 동전 투입을 기다립니다..";
        }
    }
}
