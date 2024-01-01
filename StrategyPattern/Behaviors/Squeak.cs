using IntroToDesignPatterns.Interfaces;

namespace IntroToDesignPatterns.Behaviors
{
    public class Squeak : IQuackBehavoir
    {
        public void Quack ()
        {
            Console.WriteLine("Squeak!!");
        }
    }
}
