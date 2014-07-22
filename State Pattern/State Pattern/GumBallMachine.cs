using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    class GumballMachine
    {
        State soldOutState;
        State noQuarterState;
        State hasQuarterState;
        State soldState;
        State winnerState;

        State state;
        int count = 0;

        public GumballMachine(int numberGumballs)
        {
            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);
            winnerState = new WinnerState(this);
            state = soldOutState;
            this.count = numberGumballs;
            if (numberGumballs > 0)
            {
                state = noQuarterState;
            }
        }

        public void insertQuarter()
        {
            state.insertQuarter();
        }

        public void ejectQuarter()
        {
            state.ejectQuarter();
        }

        public void turnCrank()
        {
            state.turnCrank();
            state.dispense();
        }

        public void setState(State state)
        {
            this.state = state;
        }

        public void releaseBall()
        {
            Console.WriteLine("Gumball이 나오고 있습니다...");
            if (count != 0)
            {
                count = count - 1;
            }
        }

        public int getCount()
        {
            return count;
        }

        public void refill(int count)
        {
            this.count = count;
            state = noQuarterState;
        }

        public State getState()
        {
            return state;
        }

        public State getSoldOutState()
        {
            return soldOutState;
        }

        public State getNoQuarterState()
        {
            return noQuarterState;
        }

        public State getHasQuarterState()
        {
            return hasQuarterState;
        }

        public State getSoldState()
        {
            return soldState;
        }

        public State getWinnerState()
        {
            return winnerState;
        }

        override public string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("\nMighty Gumball, Inc.");
            result.Append("\nJava-enabled Standing Gumball Model #2004");
            result.Append("\n재고: " + count + " gumball");
            if (count != 1)
            {
                result.Append("s");
            }
            result.Append("\n");
            result.Append("기계가" + state + "\n");

            return result.ToString();
        }
    }
}
