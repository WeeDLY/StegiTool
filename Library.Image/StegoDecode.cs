using Library.Utility;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.Image
{
    /// <summary>
    /// Steganography Decode class object
    /// </summary>
    /// <seealso cref="Library.Image.Stego" />
    public class StegoDecode : Stego
    {
        /// <summary>
        /// Gets the encode progress.
        /// </summary>
        /// <value>
        /// The encode progress.
        /// </value>
        public int DecodeProgress { get; private set; } = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="StegoDecode"/> class.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="loadPixels">if set to <c>true</c> [load pixels].</param>
        public StegoDecode(string filePath, bool loadPixels = true) : base(filePath, loadPixels)
        {
        }

        /// <summary>
        /// Reads the image.
        /// </summary>
        /// <returns></returns>
        public Task<string> ReadImage()
        {
            int bytesToRead = GetCharactersToRead() + Constants.MessageLength;
            string lsb = GetBits(bytesToRead * 8 + Constants.MessageLength * 8);
            List<string> chunks = Converter.StringSplitToChunks(lsb, 8);
            string message = String.Empty;
            for (int i = Constants.MessageLength; i < bytesToRead; i++)
            {
                message += Converter.BinaryToAscii(chunks[i]);
            }
            return Task.FromResult(message);
        }

        /// <summary>
        /// Gets the characters to read.
        /// </summary>
        /// <returns></returns>
        public int GetCharactersToRead()
        {
            string lsb = GetBits(Constants.MessageLength * 8);
            lsb = Converter.BinaryToAscii(lsb).Replace("A", "");
            int.TryParse(lsb, out int charsToRead);
            return charsToRead;
        }

        /// <summary>
        /// Gets the bits.
        /// </summary>
        /// <param name="chars">The chars.</param>
        /// <returns></returns>
        private string GetBits(int chars)
        {
            string bits = String.Empty;

            int read = 0;
            for(int x = 0; x < Pixels.GetLength(0); x++)
            {
                for(int y = 0; y < Pixels.GetLength(1); y++)
                {
                    if(read >= chars)
                        return bits.Substring(0, chars);
                    bits += Pixels[x, y].GetLSB();
                    read += 3;
                    DecodeProgress++;
                }
            }
            return bits;
        }
    }
}