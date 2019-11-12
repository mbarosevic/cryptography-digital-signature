using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace CryptographyDigitalSignature
{
    class Sha
    {
        //Implementation of thread-safety singleton pattern
        private static Sha instance = null;
        private static readonly object padlock = new object();

        public Sha()
        {

        }

        public static Sha Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Sha();
                    }
                    return instance;
                }
            }
        }
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
    }
}
