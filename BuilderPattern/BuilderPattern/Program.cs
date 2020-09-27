using System;
using System.Collections.Generic;

namespace BuilderPattern
{
 

    public abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract void BuildPartC();
        public abstract Product GetProduct();
    }

    public class Concrete1 : Builder
    {
        public Product product;

        public Concrete1()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.product = new Product();
        }

        public override void BuildPartA()
        {
            this.product.add("PART 1");
        }

        public override void BuildPartB()
        {
            this.product.add("PART 2");
        }

        public override void BuildPartC()
        {
            this.product.add("PART 3");
        }

        public override Product GetProduct()
        {
            Product product1 = this.product;
            this.Reset();
            return product1;
        }
    }

    public class Director
    {
        protected Builder _builder;

        public Director(Builder builder)
        {
            this._builder = builder;
        }

        public void BuildMin()
        {
            this._builder.BuildPartA();
        }

        public void BuildMax()
        {
            this._builder.BuildPartA();
            this._builder.BuildPartB();
            this._builder.BuildPartC();
        }
        
    }

    public class Product
    {
        private List<string> parts = new List<string>();

        public void add(string partName)
        {
            this.parts.Add(partName);
        }

        public void ListObjects()
        {
            for(int i = 0; i<parts.Count;i++)
            {
                Console.WriteLine(parts[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new Concrete1();
            Director director = new Director(builder);
            director.BuildMax();
            builder.GetProduct().ListObjects();

            director.BuildMin();
            builder.GetProduct().ListObjects();

            builder.BuildPartC();
            builder.GetProduct().ListObjects();

        }
    }
}
