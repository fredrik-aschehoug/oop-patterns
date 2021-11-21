using System;

namespace FactoryMethod.Product
{
    class ConcreteProductB : IProduct
    {
        public void DoStuff()
        {
            Console.WriteLine("Doing some stuff for Concrete Product B.");
        }
    }
}
