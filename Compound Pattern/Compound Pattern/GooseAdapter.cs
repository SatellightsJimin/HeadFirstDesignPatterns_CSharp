using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_Pattern
{
    class GooseAdapter : Quackable
    {
        Goose goose;
        Observable observable;
        public GooseAdapter(Goose goose)
        {
            this.observable = new Observable(this);
            this.goose = goose;
        }
        public void quack()
        {
            goose.honk();
            notifyObservers();
        }
        public GooseAdapter()
        {
            observable = new Observable(this);
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
