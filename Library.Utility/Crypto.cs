﻿using System;
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
                PasswordDeriveBytes _passwordBytes = new PasswordDeriveBytes(password, saltBytes, Settings.Hash, Settings.Iterations);
                byte[] keyBytes = GetPasswordDeriveBytes(_passwordBytes);
                if (keyBytes == null)
                {
                    return null;
                }

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
        /// Gets the password derive bytes.
        /// </summary>
        /// <param name="_passwordBytes">The password bytes.</param>
        /// <returns></returns>
        private static byte[] GetPasswordDeriveBytes(PasswordDeriveBytes _passwordBytes)
        {
            try
            {
                return _passwordBytes.GetBytes(Settings.KeySize / 8);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
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
            byte[] valueBytes;
            try
            {
                valueBytes = Convert.FromBase64String(value);
            }
            catch(FormatException e)
            {
                return e.Message;
            }
            catch(Exception e)
            {
                return "Something went horribly wrong";
            }

            byte[] decrypted;
            int decryptedByteCount = 0;

            using (T cipher = new T())
            {
                PasswordDeriveBytes _passwordBytes = new PasswordDeriveBytes(password, saltBytes, Settings.Hash, Settings.Iterations);
                byte[] keyBytes = GetPasswordDeriveBytes(_passwordBytes);
                if (keyBytes == null)
                {
                    return null;
                }

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
                    return "Wrong password";
                }

                cipher.Clear();
            }
            return Encoding.UTF8.GetString(decrypted, 0, decryptedByteCount);
        }

    }
}