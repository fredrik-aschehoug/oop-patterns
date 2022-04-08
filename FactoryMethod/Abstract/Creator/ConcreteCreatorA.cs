using FactoryMethod.Abstract.Product;

namespace FactoryMethod.Abstract.Creator
{
    class ConcreteCreatorA : Creator
    {
        public override IProduct CreateProduct()
        {
            return new ConcreteProductA();
        }
    }
}
