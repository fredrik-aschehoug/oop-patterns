using System;

namespace FactoryMethod.Product
{
    class ConcreteProductA : IProduct
    {
        public void DoStuff()
        {
            Console.WriteLine("Doing some stuff for Concrete Product A.");
        }
    }
}
