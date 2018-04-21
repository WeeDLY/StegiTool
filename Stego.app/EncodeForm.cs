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

        /// <summary>
        /// The output file
        /// </summary>
        private string _OutputFile = String.Empty;
        /// <summary>
        /// Gets or sets the output file.
        /// </summary>
        /// <value>
        /// The output file.
        /// </value>
        public string OutputFile
        {
            get => _OutputFile;
            set
            {
                _OutputFile = value;
                if(value != String.Empty)
                    LblOutputFile.Text = value;
            }
        }

        
        const string ImageFileFilter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|All files (*.*)|*.*";

        /// <summary>
        /// Initializes a new instance of the <see cref="EncodeForm"/> class.
        /// </summary>
        public EncodeForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="EncodeForm"/> class.
        /// </summary>
        /// <param name="spawnLoc">The spawn loc.</param>
        public EncodeForm(Point spawnLoc, EncodeFormProgress eProg)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = spawnLoc;


            this.OutputFile = eProg.OutputFile;

            if (eProg.Stego == null)
                return;
            this.stego = eProg.Stego;
            if(eProg.Stego.FilePath != null)
                LblFile.Text = eProg.Stego.FilePath;
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
                else
                {
                    return;
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
                }
            }
        }

        private void MenuStripDecodeForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            DecodeForm d = new DecodeForm(this.Location, new EncodeFormProgress(stego, OutputFile));
            d.ShowDialog();
            this.Close();
        }
    }
}