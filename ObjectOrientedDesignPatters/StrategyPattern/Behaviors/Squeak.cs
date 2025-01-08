using StrategyPattern.Interfaces;

namespace StrategyPattern.Behaviors
{
    public class Squeak : IQuackBehavoir
    {
        public void Quack ()
        {
            Console.WriteLine("Squeak!!");
        }
    }
}
