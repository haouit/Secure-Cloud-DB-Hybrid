using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace NT219_FinalProject.Crypto
{
    internal class RSA
    {
        private static byte[] rsaPublicKey;
        private static byte[] rsaPrivateKey;

        public byte[][] GenerateKeyPair()
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsaPublicKey = rsa.ExportRSAPublicKey();
                rsaPrivateKey = rsa.ExportRSAPrivateKey();
                return new byte[][] { rsaPublicKey, rsaPrivateKey };
            }
        }
    }
}
