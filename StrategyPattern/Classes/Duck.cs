using IntroToDesignPatterns.Interfaces;
using IntroToDesignPatterns.Behaviors;

namespace IntroToDesignPatterns.Classes
{
    public abstract class Duck
    {
        protected IFlyBehavior FlyBehavior = new FlyWithWings();

        protected IQuackBehavoir QuackBehavoir = new RegularQuack();


        public abstract void Display();

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavoir.Quack();
        }

        public void SetFlyBehavior(IFlyBehavior newFlyBehavoir)
        {
            FlyBehavior = newFlyBehavoir;
        }

        public void SetQuackBehavoir(IQuackBehavoir newQuackBehavoir)
        {
            QuackBehavoir = newQuackBehavoir;
        }
    }
}
