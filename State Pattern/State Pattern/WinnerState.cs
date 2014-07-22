using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State_Pattern
{
    class WinnerState : State
    {
        private GumballMachine gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            // TODO: Complete member initialization
            this.gumballMachine = gumballMachine;
        }

        public void insertQuarter()
        {
            Console.WriteLine("알맹이가 나오는중입니다 기다려주세요");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("알맹이가 나오는중입니다 기다려주세요");
        }

        public void turnCrank()
        {
            Console.WriteLine("두번 돌릴 수 없습니다.");
        }

        public void dispense()
        {
            Console.WriteLine("당신이 이겼습니다! Gumball 2개 획득!");
            gumballMachine.releaseBall();
            if (gumballMachine.getCount() == 0)
            {
                gumballMachine.setState(gumballMachine.getSoldOutState());
            }
            else
            {
                gumballMachine.releaseBall();
                if (gumballMachine.getCount() > 0)
                {
                    gumballMachine.setState(gumballMachine.getNoQuarterState());
                }
                else
                {
                    Console.WriteLine("품절입니다");
                    gumballMachine.setState(gumballMachine.getSoldOutState());
                }
            }
        }
    }
}
