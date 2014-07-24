using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_Pattern
{
    public class RubberDuck : Quackable
    {
        Observable observable;
        public void quack()
        {
            Console.WriteLine("삑삑");
            notifyObservers();
        }
        public RubberDuck()
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
