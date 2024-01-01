using IntroToDesignPatterns.Behaviors;
using IntroToDesignPatterns.Classes;

namespace IntroToDesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mallardDuck = new MallardDuck();
            var silentQuack = new MuteQuack();

            mallardDuck.PerformQuack();
            mallardDuck.SetQuackBehavoir(silentQuack);
            mallardDuck.PerformQuack();

        }
    }
}