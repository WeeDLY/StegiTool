using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Image
{
    public class EncodeFormProgress
    {
        public StegoImage Stego { get; }
        public string OutputFile { get; }

        public EncodeFormProgress(StegoImage stego, string outputFile)
        {
            Stego = stego;
            OutputFile = outputFile;
        }
    }
}