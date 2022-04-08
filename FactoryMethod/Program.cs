using FactoryMethod.Abstract.Creator;

namespace FactoryMethod
{
    class Program
    {
        static void Main()
        {
            Creator creator = new ConcreteCreatorA();
            var product = creator.CreateProduct();
            product.DoStuff();
            
            creator = new ConcreteCreatorB();
            product = creator.CreateProduct();
            product.DoStuff();
        }
    }
}
