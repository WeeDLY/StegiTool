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
        public Task<string> ReadImage(int charactersToRead)
        {
            int chars = charactersToRead * 8;
            string lsb = GetBits(chars);

            List<string> chunks = Converter.StringSplitToChunks(lsb, 8);
            string message = String.Empty;
            for (int i = 0; i < charactersToRead; i++)
            {
                message += Converter.BinaryToAscii(chunks[i]);
            }
            return Task.FromResult(message);
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
                    if(read > chars)
                        return bits;
                    bits += Pixels[x, y].GetLSB();
                    read++;
                    DecodeProgress++;
                }
            }
            return bits;
        }
    }
}