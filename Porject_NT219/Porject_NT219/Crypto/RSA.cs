using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Org.BouncyCastle.Crypto;

namespace NT219_FinalProject.Crypto
{
    internal class RSA_Prj
    {
        private RSAParameters publicKey;
        private RSAParameters privateKey;

        public void GenerateKeyPair()
        {
            using (RSA rsa = RSA.Create())
            {
                // Generate the key pair
                rsa.KeySize = 2048;
                publicKey = rsa.ExportParameters(false);
                privateKey = rsa.ExportParameters(true);
            }
        }

        public byte[] Encrypt(byte[] data)
        {
            using (RSA rsa = RSA.Create())
            {
                rsa.ImportParameters(publicKey);
                return rsa.Encrypt(data, RSAEncryptionPadding.Pkcs1);
            }
        }

        public byte[] Decrypt(byte[] data)
        {
            using (RSA rsa = RSA.Create())
            {
                rsa.ImportParameters(privateKey);
                return rsa.Decrypt(data, RSAEncryptionPadding.Pkcs1);
            }
        }

        public string[] GetKeyPair()
        {
            return new string[] { ExportPublicKeyToPem(publicKey), ExportPrivateKeyToPem(privateKey) };
        }

        public void SaveKeyPair(string publicKeyPath, string privateKeyPath)
        {
            // Save the key pair to file
            File.WriteAllText(publicKeyPath, ExportPublicKeyToPem(publicKey));
            File.WriteAllText(privateKeyPath, ExportPrivateKeyToPem(privateKey));
        }

        public void LoadKeyPair(string publicKeyPath, string privateKeyPath)
        {
            // Load the key pair from file
            publicKey = ImportPublicKeyFromPem(File.ReadAllText(publicKeyPath));
            privateKey = ImportPrivateKeyFromPem(File.ReadAllText(privateKeyPath));
        }

        public static string ExportPublicKeyToPem(RSAParameters publicKey)
        {
            using (RSA rsa = RSA.Create())
            {
                rsa.ImportParameters(publicKey);
                byte[] publicKeyBytes = rsa.ExportRSAPublicKey();
                return PemFormat(publicKeyBytes, "PUBLIC KEY");
            }
        }

        public static string ExportPrivateKeyToPem(RSAParameters privateKey)
        {
            using (RSA rsa = RSA.Create())
            {
                rsa.ImportParameters(privateKey);
                byte[] privateKeyBytes = rsa.ExportRSAPrivateKey();
                return PemFormat(privateKeyBytes, "PRIVATE KEY");
            }
        }

        private static string PemFormat(byte[] keyBytes, string keyType)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"-----BEGIN {keyType}-----");
            builder.AppendLine(Convert.ToBase64String(keyBytes, Base64FormattingOptions.InsertLineBreaks));
            builder.AppendLine($"-----END {keyType}-----");
            return builder.ToString();
        }
        public RSAParameters ImportPublicKeyFromPem(string publicKeyPem)
        {
            using (RSA rsa = RSA.Create())
            {
                byte[] publicKeyBytes = GetKeyBytesFromPem(publicKeyPem);
                rsa.ImportRSAPublicKey(publicKeyBytes, out _);
                publicKey = rsa.ExportParameters(false);
                return rsa.ExportParameters(false);
            }
        }

        public RSAParameters ImportPrivateKeyFromPem(string privateKeyPem)
        {
            using (RSA rsa = RSA.Create())
            {
                byte[] privateKeyBytes = GetKeyBytesFromPem(privateKeyPem);
                rsa.ImportRSAPrivateKey(privateKeyBytes, out _);
                privateKey = rsa.ExportParameters(true);
                return rsa.ExportParameters(true);
            }
        }

        public static byte[] GetKeyBytesFromPem(string pem)
        {
            string[] lines = pem.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder builder = new StringBuilder();
            foreach (string line in lines)
            {
                if (!line.StartsWith("-----"))
                {
                    builder.Append(line);
                }
            }
            return Convert.FromBase64String(builder.ToString());
        }
    }
}
