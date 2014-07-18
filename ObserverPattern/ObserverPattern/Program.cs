using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    interface Observer
    {
        
        void update(float temp, float humi, float press);
    }
    interface Subject
    {
        void registerObserver(Observer o);
        void notifyObservers();
        void removeObserver(Observer o);
    }
    interface DisplayElement
    {
        void display();
    }
    //서브젝트 구현
    class Weatherdata : Subject
    {
        private float temp;
        private float humi;
        private float press;
        List<Observer> observers = new List<Observer>();

        public void removeObserver(Observer o)
        {
            observers.Remove(o);
        }

        public void measurementsChanged()
        {
            notifyObservers();
        }
        public void setMesasurements(float temp, float humi, float press)
        {
            this.temp = temp;
            this.humi = humi;
            this.press = press;
            measurementsChanged();
        }

        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        public void notifyObservers()
        {
            foreach (Observer o in observers)
            {
                o.update(temp, humi, press);
            }
        }
    }

    //옵져버 구현
    class CurrentConditions : Observer, DisplayElement
    {
        Weatherdata w;
        private float temp;
        private float humi;
        private float press;

        public CurrentConditions(Weatherdata w){
            this.w = w;
            w.registerObserver(this);
        }



        public void update(float temp, float humi, float press)
        {
            this.temp = temp;
            this.humi = humi;
            this.press = press;
            display();
        }

        private void display()
        {
            Console.WriteLine("현재 온도 : {0} \n현재 습도 : {1} \n현재 기압 : {2}", temp, humi, press);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Weatherdata cast = new Weatherdata();
            Observer c = new CurrentConditions(cast);

            cast.setMesasurements(33.2f, 22.1f, 11f);
        }
    }
}
