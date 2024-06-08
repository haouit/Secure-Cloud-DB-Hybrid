using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace NT219_FinalProject.Crypto
{
    internal class RSA_Prj
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

        public byte[] Encrypt(byte[] data, byte[] publicKey)
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.ImportRSAPublicKey(publicKey, out _);
                return rsa.Encrypt(data, RSAEncryptionPadding.Pkcs1);
            }
        }

        public byte[] Decrypt(byte[] data, byte[] privateKey)
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.ImportRSAPrivateKey(privateKey, out _);
                return rsa.Decrypt(data, RSAEncryptionPadding.Pkcs1);
            }
        }

        public byte[] SignData(byte[] data, byte[] privateKey)
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.ImportRSAPrivateKey(privateKey, out _);
                return rsa.SignData(data, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
            }
        }

        public bool VerifyData(byte[] data, byte[] signature, byte[] publicKey)
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.ImportRSAPublicKey(publicKey, out _);
                return rsa.VerifyData(data, signature, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
            }
        }

        public string[] ExportKeyPair()
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.ImportRSAPrivateKey(rsaPrivateKey, out _);
                rsa.ImportRSAPublicKey(rsaPublicKey, out _);

                // Private key export
                string headerPrv = "-----BEGIN RSA PRIVATE KEY-----";
                string footerPrv = "-----END RSA PRIVATE KEY-----";
                string keyPrv = Convert.ToBase64String(rsa.ExportPkcs8PrivateKey());
                string PEMPrv = $"{headerPrv}\n{keyPrv}\n{footerPrv}"; 

                // Public key export
                string headerPub = "-----BEGIN RSA PUBLIC KEY-----";
                string footerPub = "-----END RSA PUBLIC KEY-----";
                string keyPub = Convert.ToBase64String(rsa.ExportRSAPublicKey());
                string PEMPub = $"{headerPub}\n{keyPub}\n{footerPub}";

                return new string[] { PEMPub, PEMPrv };
            }
        }
    }
}
