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
        public ShaAlgorithm() { }
        public new static ShaAlgorithm Instance
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

        readonly RsaAlgorithm rsaAlg = new RsaAlgorithm();
        public string HashCalculate(string plainText)
        {
            StringBuilder builder = new StringBuilder();
            //Creates a SHA256 local variable
            using (SHA256 sha256 = SHA256.Create())
            {
                //Compute Hash returns byte array saved in bytes byte array
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(plainText));

                //Converting bytes byte array to a string builder
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
            _ = rsaAlg.GetPrivateKey();
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
