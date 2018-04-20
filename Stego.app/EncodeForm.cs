using Library.Image;
using Library.Utility;
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
    /// <summary>
    /// EncodeForm, GUI Form that has the encoding of text to an image
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class EncodeForm : Form
    {
        /// <summary>
        /// The stego
        /// </summary>
        public StegoImage stego;

        private string _OutputFile = String.Empty;
        public string OutputFile { get => _OutputFile; set => _OutputFile = value; }


        /// <summary>
        /// The image file filter
        /// </summary>
        const string ImageFileFilter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|All files (*.*)|*.*";


        /// <summary>
        /// Initializes a new instance of the <see cref="EncodeForm"/> class.
        /// </summary>
        public EncodeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the BtnSelectFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private async void BtnSelectFile_Click(object sender, EventArgs e)
        {
            using(var ofd = new OpenFileDialog())
            {
                ofd.Filter = ImageFileFilter;
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    stego = new StegoImage(ofd.FileName);
                    LblFile.Text = stego.FilePath;
                }
            }
            Task tLoad = new Task(() => stego.LoadPixels());
            tLoad.Start();
            await Task.WhenAll(tLoad);
            Console.WriteLine("loaded");
        }

        /// <summary>
        /// Handles the Click event of the BtnEncode control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnEncode_Click(object sender, EventArgs e)
        {
            if (!stego.PixelLoaded)
            {
                Console.WriteLine("Not loaded");
                return;
            }

            if(TextMessage.Text.Length > 0)
                if(OutputFile == String.Empty)
                    MessageBox.Show("You have to select an output file");
                else
                    stego.CreateImage(TextMessage.Text, OutputFile);
            else
                MessageBox.Show("You have to type some text to hide");
        }

        /// <summary>
        /// Handles the Click event of the button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            stego.ReadImage();
        }

        /// <summary>
        /// Handles the Click event of the BtnClear control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            TextMessage.Text = String.Empty;
        }

        private void BtnSelectOutputFile_Click(object sender, EventArgs e)
        {
            using(var sfd = new SaveFileDialog())
            {
                sfd.Filter = ImageFileFilter;
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    OutputFile = sfd.FileName;
                    LblOutputFile.Text = OutputFile;
                }
            }
        }
    }
}