using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            creator[] creator = new creator[2];
            creator[0] = new concretecreator1();
            creator[1] = new concretecreator2();

            foreach( creator obj in creator)
            {
                Console.WriteLine(obj.GetProduct());
                Console.WriteLine(obj.ProductName());
            }
            Console.ReadLine();
        }
    }

    public abstract class Product
    {
        public abstract string ProductName();
    }

    public class Product1 : Product
    {
        public override string ProductName()
        {
            return "A";
        }
    }

    public class Product2 : Product
    {
        public override string ProductName()
        {
            return "B";
        }
    }

    public abstract class creator
    {
        public abstract string GetProduct();
        public abstract Product ProductName();
    }

    public class concretecreator1 : creator
    {
        public override string GetProduct()
        {
            return new Product1().ProductName();
        }

        public override Product ProductName()
        {
            return new Product1();
        }
    }

    public class concretecreator2 : creator
    {
        public override string GetProduct()
        {
            return new Product2().ProductName();
        }

        public override Product ProductName()
        {
            return new Product2();
        }
    }
}
