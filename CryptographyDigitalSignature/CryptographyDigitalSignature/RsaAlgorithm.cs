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

        public static RSAParameters javniKljuc;
        private static RSAParameters privatniKljuc;

        public void GenerirajKljuceve()
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                //not storing in key container
                rsa.PersistKeyInCsp = false;
                javniKljuc = rsa.ExportParameters(false);
                privatniKljuc = rsa.ExportParameters(true);
            }
        }

        public byte[] EncryptToByteArray(string text)
        {
            byte[] textToByteArray = Encoding.UTF8.GetBytes(text);
            byte[] encryptedText;
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                rsa.ImportParameters(javniKljuc);
                encryptedText = rsa.Encrypt(textToByteArray, true);
            }
            return encryptedText;
        }

        public string Encrypt(string plainText)
        {
            GenerirajKljuceve();
            string encryptedText = Convert.ToBase64String(EncryptToByteArray(plainText));
            return encryptedText;
        }


        public string DecryptToByteArray(byte[] encryptedText)
        {
            byte[] decryptedText = Array.Empty<byte>();
            try
            {
                using (var rsa = new RSACryptoServiceProvider(2048))
                {
                    rsa.PersistKeyInCsp = false;
                    rsa.ImportParameters(privatniKljuc);
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
