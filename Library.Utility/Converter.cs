using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Utility
{
    public class Converter
    {
        public static string TextToBinary(string message)
        {
            string binary = String.Empty;
            foreach (char c in message)
            {
                message += Convert.ToString(c, 2);
            }
            return binary;
        }

        public static string BinaryToText(string binary)
        {
            int value = Convert.ToInt32(binary);
            return Convert.ToString(value, 2);
        }

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
    }
}