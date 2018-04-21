using Library.Utility;
using System;
using System.Drawing;

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

        public Color GetColor(char c)
        {
            string binary = Convert.ToString(Red, 2);
            if(binary[binary.Length - 1] == c)
            {
                return Color.FromArgb(Alpha, Red, Green, Blue);
            }
            else
            {
                Console.WriteLine("Original: " + binary + " | " + c);
                binary = binary.Remove(binary.Length - 1, 1);
                binary += c;
                int value = Convert.ToInt32(binary, 2);
                Console.WriteLine(Red + " | " + binary);
                return Color.FromArgb(Alpha, value, Green, Blue);
            }
        }
        public Color GetColor(string msg)
        {
            char[] chars = msg.ToCharArray();

            for(int i = 0; i < chars.Length; i++)
            {
                switch (i)
                {
                    default:
                    case 0:
                        Red = GetColorValue(chars[i], Red);
                        break;
                    case 1:
                        Green = GetColorValue(chars[i], Green);
                        break;
                    case 2:
                        Blue = GetColorValue(chars[i], Blue);
                        break;
                }
            }
            return Color.FromArgb(Alpha, Red, Green, Blue);
        }

        private int GetColorValue(char c, int value)
        {
            string valueBinary = Convert.ToString(value, 2);
            if(valueBinary[valueBinary.Length - 1] == c)
            {
                return value;
            }
            else
            {
                valueBinary = valueBinary.Remove(valueBinary.Length - 1, 1);
                valueBinary += c;
                return Convert.ToInt32(valueBinary, 2);
            }
        }

        public string GetLSB()
        {
            string red = Convert.ToString(Red, 2);
            string green = Convert.ToString(Green, 2);
            string blue = Convert.ToString(Blue, 2);
            return red[red.Length - 1].ToString() + green[green.Length - 1] + blue[blue.Length - 1];
        }
    }
}