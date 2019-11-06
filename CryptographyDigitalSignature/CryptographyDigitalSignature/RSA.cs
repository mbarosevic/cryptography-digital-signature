using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptographyDigitalSignature
{
    class Rsa
    {
        //Implementation of thread-safety singleton pattern
        private static Rsa instance = null;
        private static readonly object padlock = new object();

        public Rsa()
        {

        }

        public static Rsa Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Rsa();
                    }
                    return instance;
                }
            }
        }

        public static RSAParameters publicKey;
        private static RSAParameters privateKey;
    }
}
