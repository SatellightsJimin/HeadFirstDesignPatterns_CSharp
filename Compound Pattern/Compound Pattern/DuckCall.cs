using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_Pattern
{
    class DuckCall : Quackable
    {
        Observable observable;
        public void quack()
        {
            Console.WriteLine("꽉꽉");
            notifyObservers();
        }
        public DuckCall()
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
