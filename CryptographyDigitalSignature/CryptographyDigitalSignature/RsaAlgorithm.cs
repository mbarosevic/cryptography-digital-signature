using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptographyDigitalSignature
{
    class RsaAlgorithm
    {
        //Implementation of thread-safety singleton pattern
        private static RsaAlgorithm instance = null;
        private static readonly object padlock = new object();

        public RsaAlgorithm()
        {

        }

        public static RsaAlgorithm Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new RsaAlgorithm();
                    }
                    return instance;
                }
            }
        }
        public RSAParameters publicKey;
        private RSAParameters privateKey;
        public void GenerateKeys()
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                //not storing in key container
                rsa.PersistKeyInCsp = false;
                publicKey = rsa.ExportParameters(false);
                privateKey = rsa.ExportParameters(true);
            }
        }

        public byte[] EncryptToByteArray(string plainText)
        {
            byte[] textToByteArray = Encoding.UTF8.GetBytes(plainText);
            byte[] encryptedText;
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                rsa.ImportParameters(publicKey);
                encryptedText = rsa.Encrypt(textToByteArray, true);
            }
            return encryptedText;
        }

        public string Encrypt(string plainText)
        {
            GenerateKeys();
            string encryptedText = Convert.ToBase64String(EncryptToByteArray(plainText));
            return encryptedText;
        }

        public string DecryptToByteArray(byte[] encryptedText)
        {
            byte[] decryptedText = new byte[] { };
            try
            {
                using (var rsa = new RSACryptoServiceProvider(2048))
                {
                    rsa.PersistKeyInCsp = false;
                    rsa.ImportParameters(privateKey);
                    decryptedText = rsa.Decrypt(encryptedText, true);
                    return Encoding.UTF8.GetString(decryptedText);
                }
            }
            catch
            {
                return null;
            }
        }

        public string Decrypt(string encryptedText)
        {
            return DecryptToByteArray(Convert.FromBase64String(encryptedText));
        }
    }
}
