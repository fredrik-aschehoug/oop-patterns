using System.Security.Cryptography;
using System.Text;

namespace FactoryMethod.Practical.Algorithms
{
    public class Sha256CEncryptionAlgorithm : IEncryptionAlgorithm
    {
        public string Encrypt(string plainText)
        {
            var hash = string.Empty;
            var encruptedBytes = SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(plainText));

            foreach (var @byte in encruptedBytes)
            {
                hash += @byte.ToString("x2");
            }

            return hash;
        }
    }
}
