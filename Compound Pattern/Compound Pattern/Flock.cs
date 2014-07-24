using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_Pattern
{
    class Flock : Quackable
    {
        Observable observable;
        ArrayList quackers = new ArrayList();
        public void add(Quackable quacker)
        {
            quackers.Add(quacker);
        }

        public Flock()
        {
            observable = new Observable(this);
        }

        public void quack()
        {
            foreach (Quackable quacker in quackers)
            {
                quacker.quack();
            }
        }

        public void registerObserver(Observer observer)
        {
            observable.registerObserver(observer);
        }

        public void notifyObservers()
        {
            observable.notifyObservers();
        }
    }
}
