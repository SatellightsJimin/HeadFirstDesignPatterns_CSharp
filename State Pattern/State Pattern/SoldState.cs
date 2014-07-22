using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State_Pattern
{
    class SoldState : State
    {
        private GumballMachine gumBallMachine;

        public SoldState(GumballMachine gumBallMachine)
        {
            // TODO: Complete member initialization
            this.gumBallMachine = gumBallMachine;
        }

        public void insertQuarter()
        {
            Console.WriteLine("알맹이가 나오는중입니다 기다려주세요");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("이미 레버를 돌리셨습니다");
        }

        public void turnCrank()
        {
            Console.WriteLine("두번 돌릴 수 없습니다");
        }

        public void dispense()
        {
            gumBallMachine.releaseBall();
            if (gumBallMachine.getCount() > 0)
            {
                gumBallMachine.setState(gumBallMachine.getNoQuarterState());
            }
            else
            {
                Console.WriteLine("이런. 품절입니다");
                gumBallMachine.setState(gumBallMachine.getSoldOutState());
            }
        }
    }
}
