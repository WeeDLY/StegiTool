using Library.Image;
using Library.Utility;
using System;
using System.Drawing;
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
        public StegoEncode SEncode;

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

        /// <summary>
        /// Initializes a new instance of the <see cref="EncodeForm" /> class.
        /// </summary>
        public EncodeForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="EncodeForm" /> class.
        /// </summary>
        /// <param name="spawnLoc">The spawn loc.</param>
        /// <param name="eProg">The e prog.</param>
        public EncodeForm(Point spawnLoc, EncodeFormProgress eProg)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = spawnLoc;

            if (eProg.SEncode == null)
                return;

            this.SEncode.OutputFile = eProg.SEncode.OutputFile;
            this.SEncode = eProg.SEncode;
            if (eProg.SEncode.FilePath != null)
                LblFile.Text = eProg.SEncode.FilePath;
        }

        /// <summary>
        /// Handles the Click event of the BtnSelectFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            using(var ofd = new OpenFileDialog())
            {
                ofd.Filter = Constants.ImageFileFilter;
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    SEncode = new StegoEncode(ofd.FileName);
                    LblFile.Text = SEncode.FilePath;
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the BtnEncode control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnEncode_Click(object sender, EventArgs e)
        {
            if (!SEncode.PixelLoaded)
            {
                Console.WriteLine("Not loaded");
                return;
            }

            if(TextMessage.Text.Length > 0)
                if(OutputFile == String.Empty)
                    MessageBox.Show("You have to select an output file");
                else
                    SEncode.CreateImage(TextMessage.Text, OutputFile);
            else
                MessageBox.Show("You have to type some text to hide");
        }

        /// <summary>
        /// Handles the Click event of the BtnClear control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            TextMessage.Text = String.Empty;
        }

        /// <summary>
        /// Handles the Click event of the BtnSelectOutputFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnSelectOutputFile_Click(object sender, EventArgs e)
        {
            using(var sfd = new SaveFileDialog())
            {
                sfd.Filter = Constants.ImageFileFilter;
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    OutputFile = sfd.FileName;
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the MenuStripDecodeForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void MenuStripDecodeForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            DecodeForm d = new DecodeForm(this.Location, new EncodeFormProgress(SEncode));
            d.ShowDialog();
            this.Close();
        }
    }
}