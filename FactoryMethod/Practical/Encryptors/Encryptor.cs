using FactoryMethod.Practical.Algorithms;
using System;

namespace FactoryMethod.Practical.Encryptors
{
    public abstract class Encryptor
    {
        public void WriteToConsole(string plaintext)
        {
            var encryptionAlgorithm = GetEncryptionAlgorithm();
            var encryptedText = encryptionAlgorithm.Encrypt(plaintext);
            Console.WriteLine(encryptedText);
        }

        protected abstract IEncryptionAlgorithm GetEncryptionAlgorithm();
    }
}
