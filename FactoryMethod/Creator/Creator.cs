using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    abstract class Creator
    {
        public abstract IProduct CreateProduct();
    }
}
