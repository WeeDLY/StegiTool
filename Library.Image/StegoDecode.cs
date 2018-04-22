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

        public void ReadImage()
        {
            string lsb = String.Empty;
            for (int x = 0; x < 8 * 20 - 1; x++)
            {
                for (int y = 0; y < 8 * 20 - 1; y++)
                {
                    lsb += Pixels[x, y].GetLSB();
                }
            }

            List<string> chunks = Converter.StringSplitToChunks(lsb, 8);
            string message = String.Empty;
            for (int i = 0; i < 20; i++)
            {
                message += Converter.BinaryToAscii(chunks[i]);
            }

            Console.WriteLine(message);
            Console.WriteLine("done");
        }
    }
}