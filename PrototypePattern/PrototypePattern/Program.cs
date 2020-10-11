using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Person P = new Person();
            P.id = new idinfo(123);
            P.name = "asda";
            Console.WriteLine("P .....");
            Console.WriteLine(P.id._idNumber);
            Console.WriteLine(P.name);

            Person p2 = P.ShallowCopy();

            Console.WriteLine("P2 .....");
            Console.WriteLine(p2.id._idNumber);
            Console.WriteLine(p2.name);

            Person p3 = P.DeepCopy();
            Console.WriteLine("P3 .....");
            Console.WriteLine(p3.id._idNumber);
            Console.WriteLine(p3.name);


            P.id._idNumber = 456;
            P.name = "dani";
            Console.WriteLine("P CO .....");
            Console.WriteLine(P.id._idNumber);
            Console.WriteLine(P.name);

            Console.WriteLine("P2 CO .....");
            Console.WriteLine(p2.id._idNumber);
            Console.WriteLine(p2.name);

            Console.WriteLine("P3 Co .....");
            Console.WriteLine(p3.id._idNumber);
            Console.WriteLine(p3.name);


            Console.ReadLine();

        }
    }

    class Person
    {
        public string name;
        public idinfo id;

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.name = String.Copy(name);
            clone.id = new idinfo(id._idNumber);
            return clone;
        }
    }

    public class idinfo
    {
        public int _idNumber;
        public idinfo(int idNumber)
        {
            this._idNumber = idNumber;
        }
    }
}
