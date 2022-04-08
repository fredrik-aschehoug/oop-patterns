using FactoryMethod.Practical.Algorithms;

namespace FactoryMethod.Practical.Encryptors
{
    public class Sha512Encryptor : Encryptor
    {
        protected override IEncryptionAlgorithm GetEncryptionAlgorithm()
        {
            return new Sha512EncryptionAlgorithm();
        }
    }
}
