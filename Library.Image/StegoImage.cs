using System;
using System.Drawing;
using System.Windows.Media.Imaging;

namespace Library.Image
{
    public class StegoImage
    {
        private BitmapImage _Image;
        public BitmapImage Image { get => _Image; set => _Image = value; }

        private PixelColor[,] _Pixels;
        public PixelColor[,] Pixels { get => _Pixels; set => _Pixels = value; }


        public StegoImage(string file)
        {
            Image = new BitmapImage(new Uri(file));
            Bitmap b = new Bitmap(file);
            Console.WriteLine(b.GetPixel(0, 0));

            Pixels = new PixelColor[b.Width, b.Height];

            for(int x = 0; x < b.Width; x++)
            {
                for(int y = 0; y < b.Height; y++)
                {
                    Pixels[x, y] = new PixelColor(b.GetPixel(x, y));
                }
            }

            Create();
        }

        public void Create()
        {
            Bitmap b = new Bitmap(Pixels.GetLength(0), Pixels.GetLength(1));
            for (int x = 0; x < Pixels.GetLength(0); x++)
            {
                for (int y = 0; y < Pixels.GetLength(1); y++)
                {
                    if(x % 2 == 0 || y % 2 == 0)
                    {
                        b.SetPixel(x, y, Pixels[x, y].GetColor());
                    }
                    else
                    {
                        b.SetPixel(x, y, Color.Black);
                    }
                }
            }

            b.Save($@"C:\Users\Blaund\Desktop\a.jpg");
        }
    }
}