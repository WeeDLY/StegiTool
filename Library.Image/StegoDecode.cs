using Library.Utility;
using System;
using System.Collections.Generic;

namespace Library.Image
{
    public class StegoDecode : Stego
    {
        public StegoDecode(string filePath, bool loadPixels = true) : base(filePath, loadPixels)
        {
        }

        public string ReadImage()
        {
            int charactersToRead = 8;
            int chars = charactersToRead * 8;

            string lsb = GetBits(chars);
            Console.WriteLine("lsb: " + lsb);

            List<string> chunks = Converter.StringSplitToChunks(lsb, 8);
            string message = String.Empty;
            for (int i = 0; i < charactersToRead; i++)
            {
                message += Converter.BinaryToAscii(chunks[i]);
            }

            Console.WriteLine(message);
            Console.WriteLine("done");
            return message;
        }

        private string GetBits(int chars)
        {
            string bits = String.Empty;

            int read = 0;
            for(int x = 0; x < Pixels.GetLength(0); x++)
            {
                for(int y = 0; y < Pixels.GetLength(1); y++)
                {
                    if(read > chars)
                        return bits;
                    bits += Pixels[x, y].GetLSB();
                    read++;
                }
            }
            return bits;
        }
    }
}