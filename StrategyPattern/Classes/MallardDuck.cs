using IntroToDesignPatterns.Classes;
using IntroToDesignPatterns.Behaviors;

namespace IntroToDesignPatterns.Classes
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
