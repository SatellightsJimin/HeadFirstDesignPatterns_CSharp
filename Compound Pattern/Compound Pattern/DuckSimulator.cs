using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_Pattern
{
    class DuckSimulator
    {
        static void Main(string[] args)
        {
            DuckSimulator simulator = new DuckSimulator();
            AbstractDuckFactory duckFactory = new CountingDuckFactory();
            simulator.simulate(duckFactory);
        }

        private void simulate(AbstractDuckFactory duckFactory)
        {


            
            
            Quackable mallardDuck = duckFactory.createMallardDuck();
            Quackable redheadDuck = duckFactory.createRedheadDuck();
            Quackable duckCall = duckFactory.createDuckCall();
            Quackable rubberDuck = duckFactory.createRubberDuck();
            Quackable goose = new GooseAdapter(new Goose());

            Flock flockOfDucks = new Flock();

            flockOfDucks.add(mallardDuck);
            flockOfDucks.add(redheadDuck);
            flockOfDucks.add(duckCall);
            flockOfDucks.add(rubberDuck);
            flockOfDucks.add(goose);

            

            Console.WriteLine("\nDuck Simulator : With goose Adapter");

            Quackable mallardDuck1 = duckFactory.createMallardDuck();
            Quackable mallardDuck2 = duckFactory.createMallardDuck();
            Quackable mallardDuck3 = duckFactory.createMallardDuck();
            Quackable mallardDuck4 = duckFactory.createMallardDuck();
            Quackable mallardDuck5 = duckFactory.createMallardDuck();

            Flock flockOfMallards = new Flock();

            flockOfMallards.add(mallardDuck1);
            flockOfMallards.add(mallardDuck2);
            flockOfMallards.add(mallardDuck3);
            flockOfMallards.add(mallardDuck4);
            flockOfMallards.add(mallardDuck5);

            flockOfDucks.add(flockOfMallards);

            Console.WriteLine();
            Console.WriteLine("Duck 시뮬레이터 : 전체 무리 시뮬레이팅");
            simulate(flockOfDucks);
            Console.WriteLine();
            Console.WriteLine("Duck 시뮬레이터 : 청둥오리 무리 시뮬레이팅");
            simulate(flockOfMallards);
            Console.WriteLine();
            Console.WriteLine("\n유일하게 오리는 총 "+QuackCounter.getQuacks() + "번 울었습니다.");
        }

        private void simulate(Quackable duck)
        {
            duck.quack();
        }

        
    }
}
