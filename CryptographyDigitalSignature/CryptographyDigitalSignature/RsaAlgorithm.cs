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
        public string Encrypt(string plainText)
        {
            UnicodeEncoding Converter = new UnicodeEncoding();
            byte[] dataToEncrypt = Converter.GetBytes(plainText);
            byte[] encryptedData;
            byte[] decryptedData;
            bool encrypted = false;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.PersistKeyInCsp = false;
                publicKey = rsa.ExportParameters(false);
                privateKey = rsa.ExportParameters(true);
                encryptedData = RSAEncrypt(dataToEncrypt, rsa.ExportParameters(false), false);
            }
            if(encryptedData != null)
            {
                return Convert.ToBase64String(encryptedData);
            }
            else
            {
                return null;
            }
        }

        public byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKeyInfo);
                    encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch
            {
                return null;
            }

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
