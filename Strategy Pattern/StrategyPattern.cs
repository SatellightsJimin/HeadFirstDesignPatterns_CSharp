using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    class StrategyPattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/////Head First Design Pattern :: Strategy Pattern/////");
            Console.WriteLine("/////http://facebook.com/satellights              /////");
            Console.WriteLine("\n\n\n#1");
            MallardDuckSimulator1();
            Console.WriteLine("\n\n\n#2");
            MallardDuckSimulator2();
            Console.WriteLine();
        }
        static void MallardDuckSimulator1()
        {
            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();

            Duck model = new ModelDuck();
            model.performFly();
            model.setFlyBehavior(new FlyRocketPowered());
            model.performFly();
        }
        static void MallardDuckSimulator2()
        {
            MallardDuck mallard = new MallardDuck();
            RubberDuck rubberDuckie = new RubberDuck();
            DecoyDuck decoy = new DecoyDuck();

            ModelDuck model = new ModelDuck();

            mallard.performQuack();
            rubberDuckie.performQuack();
            decoy.performQuack();

            model.performFly();
            model.setFlyBehavior(new FlyRocketPowered());
            model.performFly();
        }
    }

    
}
