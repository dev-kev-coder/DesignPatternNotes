using StrategyPattern.Behaviors;
using StrategyPattern.Classes;

namespace StrategyPattern
{
    public class Main
    {
        public static void Run()
        {
            var mallardDuck = new MallardDuck();
            var silentQuack = new MuteQuack();

            mallardDuck.PerformQuack();
            mallardDuck.SetQuackBehavoir(silentQuack);
            mallardDuck.PerformQuack();

        }
    }
}