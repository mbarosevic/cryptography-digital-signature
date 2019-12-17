using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace CryptographyDigitalSignature
{
    class ShaAlgorithm : RsaAlgorithm
    {
        //Implementation of thread-safety singleton pattern
        private static ShaAlgorithm instance = null;
        private static readonly object padlock = new object();

        public ShaAlgorithm()
        {

        }

        public static ShaAlgorithm Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ShaAlgorithm();
                    }
                    return instance;
                }
            }
        }

        RsaAlgorithm rsaAlg = new RsaAlgorithm();
        private static RSAParameters publicKeySignature;
        private static RSAParameters privateKeySignature;
        public string HashCalculate(string plainText)
        {
            StringBuilder builder = new StringBuilder();
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(plainText));

                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
            }
            return builder.ToString();
        }
        
        public string GenerateDigitalSignature(string hashedText)
        {
            string digitalSignature = rsaAlg.Encrypt(hashedText);
            privateKeySignature = rsaAlg.GetPrivateKey();
            return digitalSignature;
        }

        public string DecryptDigitalSignature(string digitalSignature)
        {
            if(rsaAlg.Decrypt(digitalSignature) != null)
            {
                return rsaAlg.Decrypt(digitalSignature);
            }
            else
            {
                return null;
            }
        }
    }
}
