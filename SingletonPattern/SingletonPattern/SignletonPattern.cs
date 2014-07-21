using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class SignletonPattern
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler = ChocolateBoiler.getInstance();
            boiler.fill();
            boiler.boil();
            boiler.drain();

            ChocolateBoiler boiler2 = ChocolateBoiler.getInstance();

            if (boiler.Equals(boiler2))
            {
                Console.WriteLine("boiler 1 == boiler 2");
            }
        }
    }
}
