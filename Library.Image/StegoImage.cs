using Library.Utility;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Media.Imaging;

namespace Library.Image
{
    /// <summary>
    /// 
    /// </summary>
    public class StegoImage
    {
        /// <summary>
        /// The image
        /// </summary>
        private BitmapImage _Image;
        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>
        /// The image.
        /// </value>
        public BitmapImage Image { get => _Image; set => _Image = value; }

        /// <summary>
        /// The pixels
        /// </summary>
        private PixelColor[,] _Pixels;
        /// <summary>
        /// Gets or sets the pixels.
        /// </summary>
        /// <value>
        /// The pixels.
        /// </value>
        public PixelColor[,] Pixels { get => _Pixels; set => _Pixels = value; }

        /// <summary>
        /// The file path
        /// </summary>
        private string _FilePath;
        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        /// <value>
        /// The file path.
        /// </value>
        public string FilePath { get => _FilePath; set => _FilePath = value; }

        /// <summary>
        /// The pixel loaded
        /// </summary>
        private bool _PixelLoaded = false;
        /// <summary>
        /// Gets or sets a value indicating whether [pixel loaded].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [pixel loaded]; otherwise, <c>false</c>.
        /// </value>
        public bool PixelLoaded { get => _PixelLoaded; set => _PixelLoaded = value; }

        /// <summary>
        /// Initializes a new instance of the <see cref="StegoImage"/> class.
        /// </summary>
        /// <param name="file">The file.</param>
        public StegoImage(string file)
        {
            FilePath = file;
            Image = new BitmapImage(new Uri(file));
        }

        /// <summary>
        /// Loads the pixels.
        /// </summary>
        public void LoadPixels()
        {
            Bitmap b = new Bitmap(FilePath);
            Pixels = new PixelColor[b.Width, b.Height];

            for (int x = 0; x < b.Width; x++)
            {
                for (int y = 0; y < b.Height; y++)
                {
                    Pixels[x, y] = new PixelColor(b.GetPixel(x, y));
                }
            }
            PixelLoaded = true;
        }

        /// <summary>
        /// Creates the image with hidden message
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
                    if(index < msgChunk.Count)
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

        /// <summary>
        /// Reads the image.
        /// </summary>
        public void ReadImage()
        {
            string lsb = String.Empty;
            for (int x = 0; x < 8*20; x++)
            {
                for (int y = 0; y < 8*20; y++)
                {
                    lsb += Pixels[x, y].GetLSB();
                }
            }

            List<string> chunks = Converter.StringSplitToChunks(lsb, 8);
            string message = String.Empty;
            for(int i = 0; i < 20; i++)
            {
                message += Converter.BinaryToAscii(chunks[i]);
            }

            Console.WriteLine(message);
            Console.WriteLine("done");
        }
    }
}