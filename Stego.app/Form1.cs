using Library.Image;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stego.app
{
    public partial class Form1 : Form
    {
        private string File;

        public StegoImage stego;

        const string ImageFileFilter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|All files (*.*)|*.*";

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            using(var ofd = new OpenFileDialog())
            {
                ofd.Filter = ImageFileFilter;
                ofd.AddExtension = true;
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    File = ofd.FileName;
                    stego = new StegoImage(File);
                }
            }
        }
    }
}
