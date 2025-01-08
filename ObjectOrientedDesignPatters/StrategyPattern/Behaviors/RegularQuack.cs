using StrategyPattern.Interfaces;

namespace StrategyPattern.Behaviors
{
    public class RegularQuack : IQuackBehavoir
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
