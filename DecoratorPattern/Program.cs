namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Making Espresso with Mocha");

            var espresso = new Espresso();
            
            var mochaEspresso = new Mocha(espresso);

            Console.WriteLine(mochaEspresso.Description);

            Console.ReadKey();
        }
    }

    // Setting up our abstract classes
    public abstract class Beverage
    {
        private string _desc = "Unknown Beverage";
        public virtual string Description { get => _desc; set => _desc = value; }

        public abstract double Cost();
    }

    public abstract class CondimentDecorator : Beverage
    {
        private string _desc = "Unknown Condiment";

        public override string Description { get => _desc; }
    }

    // Concrete Implementations
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }

    public class HouseBlend : Beverage 
    {
        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }

        public override double Cost()
        {
            return .89;
        }
    }

    public class Mocha : CondimentDecorator 
    {
        private Beverage _beverage;

        public override string Description { get => _beverage.Description + " Mocha"; }

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost()
        {
            return .20 + _beverage.Cost();
        }
    }
}
