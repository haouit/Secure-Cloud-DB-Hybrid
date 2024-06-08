using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using Org.BouncyCastle.Crypto;

namespace NT219_FinalProject.Crypto
{
    internal class AES
    {
        private static byte[] key = new byte[32];
        private static byte[] iv = new byte[16];

        public bool KeyIVGen()
        {
            try
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Mode = CipherMode.ECB;
                    key = aes.Key;
                    iv = aes.IV;
                }

                // Save key and iv to file in binary format
                SaveKeyAndIVToFile("key.bin", key);
                SaveKeyAndIVToFile("iv.bin", iv);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public byte[] Encrypt(byte[] data, byte[] key = null, byte[] iv = null)
        {
            if (key.Length != 32 || iv.Length != 16)
            {
                throw new Exception("Invalid key or iv length");
            }
            using (Aes aes = Aes.Create())
            {
                aes.Mode = CipherMode.ECB;
                aes.Key = key;
                aes.IV = iv;
                aes.Padding = PaddingMode.PKCS7;
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(data, 0, data.Length);
                    }
                    return ms.ToArray();
                }
            }
        }

        public byte[] Decrypt(byte[] data, byte[] key, byte[] iv)
        {
            if (key.Length != 32 || iv.Length != 16)
            {
                throw new Exception("Invalid key or iv length");
            }

            using (Aes aes = Aes.Create())
            {
                aes.Mode = CipherMode.ECB;
                aes.Key = key;
                aes.IV = iv;
                aes.Padding = PaddingMode.PKCS7;
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(data, 0, data.Length);
                    }
                    return ms.ToArray();
                }
            }
        }

        private void SaveKeyAndIVToFile(string fileName, byte[] data)
        {
            File.WriteAllBytes(fileName, data);
        }
    }
}
