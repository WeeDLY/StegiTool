using Library.Utility;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Media.Imaging;

namespace Library.Image
{
    public class StegoImage
    {
        private BitmapImage _Image;
        public BitmapImage Image { get => _Image; set => _Image = value; }

        private PixelColor[,] _Pixels;
        public PixelColor[,] Pixels { get => _Pixels; set => _Pixels = value; }

        private string _FilePath;
        public string FilePath { get => _FilePath; set => _FilePath = value; }

        private bool _PixelLoaded = false;
        public bool PixelLoaded { get => _PixelLoaded; set => _PixelLoaded = value; }

        public StegoImage(string file)
        {
            FilePath = file;
            Image = new BitmapImage(new Uri(file));
        }

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

        public void CreateImage(string msg, string outputFile)
        {
            string binary = Converter.AsciiToBinary(msg);
            char[] message = binary.ToCharArray();

            Bitmap b = new Bitmap(Pixels.GetLength(0), Pixels.GetLength(1));
            int index = 0;
            for (int x = 0; x < Pixels.GetLength(0); x++)
            {
                for (int y = 0; y < Pixels.GetLength(1); y++)
                {
                    Color c = Pixels[x, y].GetColor();
                    if(index < message.Length)
                    {
                        char a = message[index];
                        c = Pixels[x, y].GetColor(a);
                    }

                    b.SetPixel(x, y, c);
                    index++;
                }
            }

            b.Save(outputFile);
        }

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
            Console.WriteLine("chunks");
            Console.WriteLine(lsb);
            List<string> chunks = new List<string>();

            int chunkSize = 8;
            int stringLength = 8 * 20;
            for (int i = 0; i < stringLength; i += chunkSize)
            {
                if (i + chunkSize > stringLength)
                    chunkSize = stringLength - i;
                chunks.Add(Converter.BinaryToAscii(lsb.Substring(i, chunkSize)));
            }

            string message = String.Empty;
            for(int i = 0; i < 20; i++)
            {
                message += chunks[i];
            }


            Console.WriteLine(message);
            Console.WriteLine("done");
        }
    }
}