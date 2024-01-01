using IntroToDesignPatterns.Interfaces;

namespace IntroToDesignPatterns.Behaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.Write("Flapping Wings..");
        }
    }
}
