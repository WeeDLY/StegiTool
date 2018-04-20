using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Image
{
    public class PixelColor
    {
        public int Alpha;
        public int Red;
        public int Green;
        public int Blue;
        public PixelColor(int alpha, int red, int green, int blue)
        {
            Alpha = alpha;
            Red = red;
            Green = green;
            Blue = blue;
        }
        public PixelColor(Color c)
        {
            Alpha = c.A;
            Red = c.R;
            Green = c.G;
            Blue = c.B;
        }

        public Color GetColor()
        {
            return Color.FromArgb(Alpha, Red, Green, Blue);
        }
    }
}