using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Library.Utility
{
    public class Crypto
    {
        public static byte[] AesEncrypt(byte[] data, byte[] key)
        {
            using(var aes = Aes.Create())
            {
                aes.Padding = PaddingMode.PKCS7;
                aes.Mode = CipherMode.CBC;
                byte[] iv = aes.IV;

                using (ICryptoTransform encryptor = aes.CreateEncryptor(key, iv))
                using (var stream = new MemoryStream())
                {
                    stream.Write(iv, 0, iv.Length);
                    using(var cryptoStream = new CryptoStream(stream, encryptor, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(data, 0, data.Length);
                    }
                    return stream.ToArray();
                }
            }
        }

        public static byte[] AesDecrypt(byte[] encryptedText, byte[] key)
        {
            using(var aes = Aes.Create())
            {
                aes.Padding = PaddingMode.PKCS7;
                aes.Mode = CipherMode.CBC;

                byte[] iv = aes.IV;
                aes.Key = key;

                using(MemoryStream stream = new MemoryStream())
                using (CryptoStream cryptoStream = new CryptoStream(stream, aes.CreateDecryptor(key, iv), CryptoStreamMode.Read))
                {
                    cryptoStream.Write(encryptedText, 0, encryptedText.Length);
                    cryptoStream.FlushFinalBlock();

                    return stream.ToArray();
                }
            }
        }
    }
}