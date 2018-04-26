using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Library.Utility
{
    /// <summary>
    /// Crypto utility class
    /// </summary>
    public static class Crypto
    {
        /// <summary>
        /// Encrypts the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public static string Encrypt(string value, string password)
        {
            return Encrypt<AesManaged>(value, password);
        }
        /// <summary>
        /// Encrypts the specified value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public static string Encrypt<T>(string value, string password)
                where T : SymmetricAlgorithm, new()
        {
            byte[] vectorBytes = Encoding.ASCII.GetBytes(Settings.Vector);
            byte[] saltBytes = Encoding.ASCII.GetBytes(Settings.Salt);
            byte[] valueBytes = Encoding.UTF8.GetBytes(value);

            byte[] encrypted;
            using (T cipher = new T())
            {
                PasswordDeriveBytes _passwordBytes =
                    new PasswordDeriveBytes(password, saltBytes, Settings.Hash, Settings.Iterations);
                byte[] keyBytes = _passwordBytes.GetBytes(Settings.KeySize / 8);

                cipher.Mode = CipherMode.CBC;

                using (ICryptoTransform encryptor = cipher.CreateEncryptor(keyBytes, vectorBytes))
                using (MemoryStream to = new MemoryStream())
                using (CryptoStream writer = new CryptoStream(to, encryptor, CryptoStreamMode.Write))
                {
                    writer.Write(valueBytes, 0, valueBytes.Length);
                    writer.FlushFinalBlock();
                    encrypted = to.ToArray();
                }
                cipher.Clear();
            }
            return Convert.ToBase64String(encrypted);
        }

        /// <summary>
        /// Decrypts the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public static string Decrypt(string value, string password)
        {
            return Decrypt<AesManaged>(value, password);
        }
        /// <summary>
        /// Decrypts the specified value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public static string Decrypt<T>(string value, string password) where T : SymmetricAlgorithm, new()
        {
            byte[] vectorBytes = Encoding.ASCII.GetBytes(Settings.Vector);
            byte[] saltBytes = Encoding.ASCII.GetBytes(Settings.Salt);
            byte[] valueBytes = Convert.FromBase64String(value);

            byte[] decrypted;
            int decryptedByteCount = 0;

            using (T cipher = new T())
            {
                PasswordDeriveBytes _passwordBytes = new PasswordDeriveBytes(password, saltBytes, Settings.Hash, Settings.Iterations);
                byte[] keyBytes = _passwordBytes.GetBytes(Settings.KeySize / 8);

                cipher.Mode = CipherMode.CBC;

                try
                {
                    using (ICryptoTransform decryptor = cipher.CreateDecryptor(keyBytes, vectorBytes))
                    using (MemoryStream from = new MemoryStream(valueBytes))
                    using (CryptoStream reader = new CryptoStream(from, decryptor, CryptoStreamMode.Read))
                    {
                        decrypted = new byte[valueBytes.Length];
                        decryptedByteCount = reader.Read(decrypted, 0, decrypted.Length);
                    }
                }
                catch (Exception ex)
                {
                    return String.Empty;
                }

                cipher.Clear();
            }
            return Encoding.UTF8.GetString(decrypted, 0, decryptedByteCount);
        }

    }
}