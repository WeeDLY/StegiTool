using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Library.Image
{
    public abstract class Stego
    {
        private string _FilePath;
        public string FilePath { get => _FilePath; set => _FilePath = value; }

        private BitmapImage _Image;
        public BitmapImage Image { get => _Image; set => _Image = value; }

        private PixelColor[,] _Pixels;
        public PixelColor[,] Pixels { get => _Pixels; set => _Pixels = value; }

        private bool _PixelLoaded = false;
        public bool PixelLoaded { get => _PixelLoaded; set => _PixelLoaded = value; }

        public int MaxCharacters { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Stego"/> class.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="loadPixels">if set to <c>true</c> [load pixels].</param>
        public Stego(string filePath, bool loadPixels = true)
        {
            FilePath = filePath;
            Image = new BitmapImage(new Uri(FilePath));

            if (loadPixels)
            {
                StartLoadingPixelsAsync();
            }
        }

        /// <summary>
        /// Starts the loading pixels asynchronous.
        /// </summary>
        public async void StartLoadingPixelsAsync()
        {
            if (FilePath == null)
                return;

            Task tLoadPixels = new Task(() => LoadPixels());
            tLoadPixels.Start();
            await Task.WhenAll(tLoadPixels);
            PixelLoaded = true;
            Console.WriteLine(PixelLoaded);
            MaxCharacters = GetMaxCharacters();
        }

        /// <summary>
        /// Loads the pixels.
        /// </summary>
        private void LoadPixels()
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
        /// Gets the maximum amount of characters, there is space for in the image
        /// </summary>
        /// <returns>Max amount of characters</returns>
        private int GetMaxCharacters()
        {
            double pixelCount = Pixels.GetLength(0) * Pixels.GetLength(1);
            double rgbCount = pixelCount * 3;
            return (int)Math.Floor(rgbCount / 8);
        }
    }
}