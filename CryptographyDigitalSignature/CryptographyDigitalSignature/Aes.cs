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

        Aes()
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
    }
}
