using FactoryMethod.Abstract.Creator;
using FactoryMethod.Practical.Encryptors;

namespace FactoryMethod
{
    class Program
    {
        static void Main()
        {
            RunAbstractImplementation();
            RunPracticalImplementation();
        }

        private static void RunPracticalImplementation()
        {
            Encryptor encryptor = new Sha256Encryptor();
            encryptor.WriteToConsole("plain text");
            
            encryptor = new Sha512Encryptor();
            encryptor.WriteToConsole("plain text");
        }

        private static void RunAbstractImplementation()
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
