using StrategyPattern.Interfaces;

namespace StrategyPattern.Behaviors
{
    public class MuteQuack : IQuackBehavoir
    {
        public void Quack()
        {
            Console.WriteLine("*Silence*");
        }
    }
}
