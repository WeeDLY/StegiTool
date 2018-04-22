using Library.Utility;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Library.Image
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Library.Image.Stego" />
    public class StegoEncode : Stego
    {
        /// <summary>
        /// The output file
        /// </summary>
        private string _OutputFile = String.Empty;
        public string OutputFile { get => _OutputFile; set => _OutputFile = value; }

        /// <summary>
        /// Initializes a new instance of the <see cref="StegoEncode"/> class.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="loadPixels">if set to <c>true</c> [load pixels].</param>
        public StegoEncode(string filePath, bool loadPixels = true) : base(filePath, loadPixels)
        {
        }

        /// <summary>
        /// Creates the image.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        /// <param name="outputFile">The output file.</param>
        public void CreateImage(string msg, string outputFile)
        {
            string binary = Converter.AsciiToBinary(msg);
            List<string> msgChunk = Converter.StringSplitToChunks(binary, 3);

            Bitmap b = new Bitmap(Pixels.GetLength(0), Pixels.GetLength(1));

            int index = 0;
            for (int x = 0; x < Pixels.GetLength(0); x++)
            {
                for (int y = 0; y < Pixels.GetLength(1); y++)
                {
                    if (index < msgChunk.Count)
                    {
                        Color c = Pixels[x, y].GetColor(msgChunk[index]);
                        b.SetPixel(x, y, c);
                    }
                    else
                    {
                        Color c = Pixels[x, y].GetColor();
                        b.SetPixel(x, y, c);
                    }
                    index++;
                }
            }

            b.Save(outputFile);
        }

    }
}