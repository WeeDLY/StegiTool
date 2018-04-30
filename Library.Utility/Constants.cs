using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Utility
{
    public class Constants
    {
        public const string ImageFileFilter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|All files (*.*)|*.*";
        public const int MessageLength = 9; // Length of characters at the start of the file, that are used to store the length of the hidden message
    }
}