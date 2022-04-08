using FactoryMethod.Practical.Algorithms;

namespace FactoryMethod.Practical.Encryptors
{
    public class Sha256Encryptor : Encryptor
    {
        protected override IEncryptionAlgorithm GetEncryptionAlgorithm()
        {
            return new Sha256CEncryptionAlgorithm();
        }
    }
}
