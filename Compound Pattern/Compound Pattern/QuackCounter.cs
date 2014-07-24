using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_Pattern
{
    public class QuackCounter : Quackable
    {
        Observable observable;
        Quackable duck;
        static int numberOfQuacks;

        public QuackCounter()
        {
            this.observable = new Observable(this);
        }
        public QuackCounter(Quackable duck)
        {
            this.duck = duck;
        }


        public void quack()
        {
            duck.quack();
            numberOfQuacks++;
        }

        public static int getQuacks()
        {
            return numberOfQuacks;
        }


        public void registerObserver(Observer observer)
        {
            observable.registerObserver(observer);
        }

        public void notifyObservers()
        {
            throw new NotImplementedException();
        }
    }
}
