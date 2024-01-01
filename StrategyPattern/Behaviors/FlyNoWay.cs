using IntroToDesignPatterns.Interfaces;

namespace IntroToDesignPatterns.Behaviors
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.Write("Cannot Fly");
        }
    }
}
