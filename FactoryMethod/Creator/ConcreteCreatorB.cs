using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    class ConcreteCreatorB : Creator
    {
        public override IProduct CreateProduct()
        {
            return new ConcreteProductB();
        }
    }
}
