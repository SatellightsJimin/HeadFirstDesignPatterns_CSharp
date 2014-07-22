using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State_Pattern
{
    class HasQuarterState : State
    {
        Random randomWinner = new Random();
        private GumballMachine gumBallMachine;

        public HasQuarterState(GumballMachine gumBallMachine)
        {
            // TODO: Complete member initialization
            this.gumBallMachine = gumBallMachine;
        }

        public void insertQuarter()
        {
            Console.WriteLine("동전이 이미 들어가 있습니다");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("동전이 반환됩니다");
            gumBallMachine.setState(gumBallMachine.getNoQuarterState());
        }

        public void turnCrank()
        {
            Console.WriteLine("손잡이를 돌렸습니다");
            int winner = randomWinner.Next(10);
            if ((winner == 0) && (gumBallMachine.getCount() > 1))
            {
                gumBallMachine.setState(gumBallMachine.getWinnerState());
            }
            else
            {
                gumBallMachine.setState(gumBallMachine.getSoldState());
            }
            
        }

        public void dispense()
        {
            Console.WriteLine("알맹이가 나갈 수 없습니다");
        }
    }
}
