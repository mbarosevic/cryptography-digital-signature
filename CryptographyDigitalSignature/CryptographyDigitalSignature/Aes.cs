using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace CryptographyDigitalSignature
{
    public sealed class Aes
    {
        //Implementation of thread-safety singleton pattern
        private static Aes instance = null;
        private static readonly object padlock = new object();

        public Aes()
        {

        }

        public static Aes Instance
        {
            get
            {
                lock (padlock)
                {
                    if(instance == null)
                    {
                        instance = new Aes();
                    }
                    return instance;
                }
            }
        }

        public string key = "";
        public string iVector = "";
        const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890+?=!-_";
        int length = 16;

        public void GenerateKey()
        {
            using(RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider())
            {
                while(key.Length != length)
                {
                    byte[] oneByte = new byte[1];
                    provider.GetBytes(oneByte);
                    char character = (char)oneByte[0];
                    if (valid.Contains(character))
                    {
                        key += character;
                    }
                }
            }
        }

        public void GenerateIVector()
        {
            using (RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider())
            {
                while (iVector.Length != length)
                {
                    byte[] oneByte = new byte[1];
                    provider.GetBytes(oneByte);
                    char character = (char)oneByte[0];
                    if (valid.Contains(character))
                    {
                        iVector += character;
                    }
                }
            }
        }

        public byte[] EncryptToByteArray(string plainText)
        {
            byte[] textToBytes = Encoding.UTF8.GetBytes(plainText);

            using(var aes = new AesCryptoServiceProvider())
            {
                aes.BlockSize = 128;
                aes.KeySize = 128;

                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = Encoding.UTF8.GetBytes(iVector);

                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.Zeros;

                using (ICryptoTransform kriptiraj = aes.CreateEncryptor(aes.Key, aes.IV))
                {
                    return kriptiraj.TransformFinalBlock(textToBytes, 0, textToBytes.Length);
                }
            }
        }

        public string Encrypt(string plainText)
        {
            GenerateKey();
            GenerateIVector();
            string encryptedText = Convert.ToBase64String(EncryptToByteArray(plainText));
            return encryptedText;
        }
    }
}
