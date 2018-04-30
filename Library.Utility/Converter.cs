using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Utility
{
    /// <summary>
    /// Converter utility class
    /// </summary>
    public class Converter
    {
        /// <summary>
        /// Binaries to ASCII.
        /// </summary>
        /// <param name="binary">The binary.</param>
        /// <returns></returns>
        public static string BinaryToAscii(string binary)
        {
            var list = new List<Byte>();
            for (int i = 0; i < binary.Length; i += 8)
            {
                String t = binary.Substring(i, 8);
                list.Add(Convert.ToByte(t, 2));
            }
            return Encoding.ASCII.GetString(list.ToArray());
        }

        /// <summary>
        /// ASCIIs to binary.
        /// </summary>
        /// <param name="ascii">The ASCII.</param>
        /// <returns></returns>
        public static string AsciiToBinary(string ascii)
        {
            string binary = String.Empty;
            byte[] bytes = Encoding.ASCII.GetBytes(ascii);
            foreach(byte b in bytes)
            {
                string bin = Convert.ToString(b, 2);
                string padding = new String('0', 8 - bin.Length);
                binary += padding + bin;
            }
            return binary;
        }

        /// <summary>
        /// Strings the split to chunks.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="chunkSize">Size of the chunk.</param>
        /// <param name="removeOffset">if set to <c>true</c> [remove offset].</param>
        /// <returns></returns>
        public static List<string> StringSplitToChunks(string text, int chunkSize, bool removeOffset = false)
        {
            List<string> chunk = new List<string>();

            for(int i = 0; i < text.Length; i += chunkSize)
            {
                if(i + chunkSize > text.Length)
                {
                    if (removeOffset)
                        chunkSize = text.Length - i;
                    else
                        break;
                }
                chunk.Add(text.Substring(i, chunkSize));
            }
            return chunk;
        }

        /// <summary>
        /// ASCIIs to base64.
        /// </summary>
        /// <param name="ascii">The ASCII.</param>
        /// <returns></returns>
        public static string AsciiToBase64(string ascii)
        {
            byte[] asciiBytes = Encoding.UTF8.GetBytes(ascii);
            return Convert.ToBase64String(asciiBytes);
        }

        /// <summary>
        /// Base64s to ASCII.
        /// </summary>
        /// <param name="base64">The base64.</param>
        /// <returns></returns>
        public static string Base64ToAscii(string base64)
        {
            byte[] base64Bytes = Convert.FromBase64String(base64);
            return Encoding.UTF8.GetString(base64Bytes);
        }

    }
}