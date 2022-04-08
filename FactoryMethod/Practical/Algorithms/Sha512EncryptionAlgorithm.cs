using System.Security.Cryptography;
using System.Text;

namespace FactoryMethod.Practical.Algorithms
{
    public class Sha512EncryptionAlgorithm : IEncryptionAlgorithm
    {
        public string Encrypt(string plainText)
        {
            var hash = string.Empty;
            var encruptedBytes = SHA512.Create().ComputeHash(Encoding.ASCII.GetBytes(plainText));

            foreach (var @byte in encruptedBytes)
            {
                hash += @byte.ToString("x2");
            }

            return hash;
        }
    }
}
