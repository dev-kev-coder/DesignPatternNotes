using IntroToDesignPatterns.Interfaces;

namespace IntroToDesignPatterns.Behaviors
{
    public class MuteQuack : IQuackBehavoir
    {
        public void Quack()
        {
            Console.WriteLine("*Silence*");
        }
    }
}
