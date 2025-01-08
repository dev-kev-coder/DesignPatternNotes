using StrategyPattern.Classes;
using StrategyPattern.Behaviors;

namespace StrategyPattern.Classes
{
    public class MallardDuck : Duck
    {

        public MallardDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavoir = new RegularQuack();
        }

        public override void Display()
        {
            Console.WriteLine("Displaying Mallard");
        }
    }
}
