using StrategyPattern.Interfaces;

namespace StrategyPattern.Behaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.Write("Flapping Wings..");
        }
    }
}
