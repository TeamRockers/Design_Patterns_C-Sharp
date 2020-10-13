using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Target tr = new Adapter();
            tr.Display();
            Console.ReadLine();
        }
    }

    class Target
    {
        public virtual void Display()
        {
            Console.WriteLine("Target Request");
        }
    }

    class Adapter: Target
    {
        private Adaptee adaptee = new Adaptee();

        public override void Display()
        {
            adaptee.SpecificRequest();
        }
    }

    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Adapter Request");
        }
    }
}
