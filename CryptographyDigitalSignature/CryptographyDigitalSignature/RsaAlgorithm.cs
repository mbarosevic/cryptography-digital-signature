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


        public UnicodeEncoding ByteConverter = new UnicodeEncoding();
        public RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        byte[] plaintext;
        byte[] encryptedtext;


        public byte[] Encryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    encryptedData = RSA.Encrypt(Data, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }


        public byte[] Decryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    decryptedData = RSA.Decrypt(Data, DoOAEPPadding);
                }
                return decryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

    }
}
