using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern
{
    class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;
        private volatile static ChocolateBoiler uniqueInstance; //멀티스레딩 이슈 해결.

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public static ChocolateBoiler getInstance()
        {
            if (uniqueInstance == null)
            {
                Console.WriteLine("Creating unique instance of Chocolate Boiler");
                uniqueInstance = new ChocolateBoiler();
            }
            Console.WriteLine("Returning instance of chocolate boiler");
            return uniqueInstance;
        }

        public void fill()
        {
            if (isEmpty())
            {
                empty = false;
                boiled = false; 
                //보일러에 우유/초콜릿 혼합재료 넣음
            }
        }

        public void drain()
        {
            if (!isEmpty() && isBoiled())
            {
                //끓인 재료를 다음 제조 단계로.
                empty = true; 
            }
        }

        public void boil()
        {
            if (!isEmpty() && !isBoiled())
            {
                //재료가 가득차있으니 끓임.
                boiled = true;
            }
        }

        public bool isEmpty()
        {
            return empty;
        }

        public bool isBoiled()
        {
            return boiled;
        }
           
        
    }
}
