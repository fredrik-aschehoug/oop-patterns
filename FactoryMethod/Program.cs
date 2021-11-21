using FactoryMethod.Creator;

namespace FactoryMethod
{
    class Program
    {
        static void Main()
        {
            var creator = new ConcreteCreatorA();
            var product = creator.CreateProduct();
            product.DoStuff();
        }
    }
}
