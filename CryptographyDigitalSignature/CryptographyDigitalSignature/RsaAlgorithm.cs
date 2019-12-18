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

        public RsaAlgorithm() { }

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
        public static RSAParameters publicKey;
        private static RSAParameters privateKey;

        //used for storing public and private key in xml format
        public string publicAndPrivateKey;

        /// <summary>
        /// Method that Generates public and private key using RSACryptoServiceProvider - 2048 bit
        /// Public and private key are exported in xml format in publicAndPrivateKey variable
        /// </summary>
        public void GenerateKeys()
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                //not storing in key container
                rsa.PersistKeyInCsp = false;
                publicKey = rsa.ExportParameters(false);
                privateKey = rsa.ExportParameters(true);

                publicAndPrivateKey = rsa.ToXmlString(true);
            }
        }

        public byte[] EncryptToByteArray(string text)
        {
            byte[] textToByteArray = Encoding.UTF8.GetBytes(text);
            byte[] encryptedText;
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                rsa.ImportParameters(publicKey);
                encryptedText = rsa.Encrypt(textToByteArray, true);
            }
            return encryptedText;
        }
        /// <summary>
        /// Main Encryption method that encrypts plain text with additional Encrypt to byte array method above.
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns>
        /// Converted Base64 Encrypted Text from EncryptToByteArray method.
        /// </returns>
        public string Encrypt(string plainText)
        {
            GenerateKeys();
            string encryptedText = Convert.ToBase64String(EncryptToByteArray(plainText));
            return encryptedText;
        }


        public string DecryptToByteArray(byte[] encryptedText)
        {
            //byte[] decryptedText = Array.Empty<byte>();
            try
            {
                using (var rsa = new RSACryptoServiceProvider(2048))
                {
                    rsa.PersistKeyInCsp = false;
                    rsa.ImportParameters(privateKey);
                    byte[] decryptedText = rsa.Decrypt(encryptedText, true);
                    return Encoding.UTF8.GetString(decryptedText);
                }
            }
            catch
            {
                return null;
            }

        }
        /// <summary>
        /// Main Decryption method that decrypts encrypted text using decrypt to byte array method.
        /// </summary>
        /// <param name="encryptedText"></param>
        /// <returns>
        /// Decrypted string text
        /// </returns>
        public string Decrypt(string encryptedText)
        {
            return DecryptToByteArray(Convert.FromBase64String(encryptedText));
        }

        public RSAParameters GetPrivateKey()
        {
            return privateKey;
        }

        public string GetPublicAndPrivateKey()
        {
            return publicAndPrivateKey;
        }

    }
}
