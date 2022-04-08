using FactoryMethod.Abstract.Product;

namespace FactoryMethod.Abstract.Creator
{
    abstract class Creator
    {
        public abstract IProduct CreateProduct();
    }
}
