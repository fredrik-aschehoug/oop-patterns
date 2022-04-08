using FactoryMethod.Abstract.Product;

namespace FactoryMethod.Abstract.Creator
{
    class ConcreteCreatorB : Creator
    {
        public override IProduct CreateProduct()
        {
            return new ConcreteProductB();
        }
    }
}
