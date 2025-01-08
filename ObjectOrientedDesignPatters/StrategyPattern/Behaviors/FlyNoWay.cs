using StrategyPattern.Interfaces;

namespace StrategyPattern.Behaviors
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.Write("Cannot Fly");
        }
    }
}
