using System;
using System.IO;
using System.Security.Cryptography;
namespace CryptographyDigitalSignature
{
    public sealed class AesAlgorithm
    {
        //Implementation of thread-safety singleton pattern
        private static AesAlgorithm instance = null;
        private static readonly object padlock = new object();

        public AesAlgorithm()
        {

        }

        public static AesAlgorithm Instance
        {
            get
            {
                lock (padlock)
                {
                    if(instance == null)
                    {
                        instance = new AesAlgorithm();
                    }
                    return instance;
                }
            }
        }

        public byte[] EncryptToByteArray(string plainText, byte[] Key, byte[] IV)
        {
            //check arguments -> call method for check
            /*
            if(plainText == null || plainText.Length <= 0)
            {

            }*/
            byte[] encrypted;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using(MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                    }
                    encrypted = msEncrypt.ToArray();
                }

            }
            return encrypted;
        }

    }
}
