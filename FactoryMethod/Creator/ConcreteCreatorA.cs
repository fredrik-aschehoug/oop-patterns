using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    class ConcreteCreatorA : Creator
    {
        public override IProduct CreateProduct()
        {
            return new ConcreteProductA();
        }
    }
}
