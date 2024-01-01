using IntroToDesignPatterns.Interfaces;

namespace IntroToDesignPatterns.Behaviors
{
    public class RegularQuack : IQuackBehavoir
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
