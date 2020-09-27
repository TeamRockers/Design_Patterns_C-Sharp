using System;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ContinentFactory continentFactory = new AmericaContinent();
            AnimalFactory animalFactory = new AnimalFactory(continentFactory);
            animalFactory.wildFoodChain();

            continentFactory = new AfricaContinent();
            animalFactory = new AnimalFactory(continentFactory);
            animalFactory.wildFoodChain();

            Console.ReadLine();
        }
    }

    public abstract class ContinentFactory
    {
        public abstract Herbivore createHerbivore();
        public abstract Carnivore createCarnivore();
    }

    public  class AfricaContinent: ContinentFactory
    {
        public override Carnivore createCarnivore()
        {
            return new Lion();
        }

        public  override Herbivore createHerbivore()
        {
            return new Goat();
        }

    }

    public  class AmericaContinent : ContinentFactory
    {
        public override Carnivore createCarnivore()
        {
            return new Wolf();
        }

        public override Herbivore createHerbivore()
        {
            return new Deer();
        }
    }

    public abstract class Herbivore
    {

    }

    public abstract class Carnivore
    {
        public abstract void Eat(Herbivore h);
    }

    public  class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }

    public class Goat : Herbivore
    {

    }

    public class Wolf: Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }

    public class Deer : Herbivore
    {

    }


    public class AnimalFactory
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;

        public AnimalFactory(ContinentFactory continentFactory)
        {
          _herbivore =   continentFactory.createHerbivore();
          _carnivore = continentFactory.createCarnivore();

        }

        public void wildFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}
