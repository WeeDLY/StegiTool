using Library.Image;
using Library.Utility;
using System;
using System.Drawing;
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
        /// The steg encode
        /// </summary>
        public StegoEncode StegEncode;

        /// <summary>
        /// The steg decode
        /// </summary>
        public StegoDecode StegDecode;

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
        public EncodeForm(Point spawnLoc, StegoEncode stegEncode, StegoDecode stegDecode)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = spawnLoc;

            this.StegDecode = stegDecode;

            if (stegEncode == null)
                return;

            this.StegEncode = stegEncode;
            this.StegEncode.OutputFile = stegEncode.OutputFile;

            if (stegEncode.FilePath != null)
                LblFile.Text = stegEncode.FilePath;
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
                    StegEncode = new StegoEncode(ofd.FileName);
                    LblFile.Text = StegEncode.FilePath;
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the BtnEncode control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private async void BtnEncodeAsync_ClickAsync(object sender, EventArgs e)
        {
            string message = TextMessage.Text;

            if (!StegEncode.PixelLoaded)
            {
                Console.WriteLine("Not loaded");
                return;
            }

            if(message.Length <= 0)
            {
                MessageBox.Show("You have to type some text to hide");
                return;
            }
            if(StegEncode.OutputFile == null)
            {
                MessageBox.Show("You have to select an output file");
                return;
            }

            if(message.Length > StegEncode.MaxCharacters)
            {
                MessageBox.Show("Your hidden message is too long");
            }

            Task tEncode = new Task(() => StegEncode.CreateImage(message, StegEncode.OutputFile));
            tEncode.Start();
            await Task.WhenAll(tEncode);
            Console.WriteLine("Done encoding");
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
            if (StegEncode == null)
            {
                MessageBox.Show("You need to select <Selected File> first");
                return;
            }
            using(var sfd = new SaveFileDialog())
            {
                sfd.Filter = Constants.ImageFileFilter;
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    StegEncode.OutputFile = sfd.FileName;
                    LblOutputFile.Text = StegEncode.OutputFile;
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
            DecodeForm d = new DecodeForm(this.Location, StegDecode, StegEncode);
            d.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Handles the TextChanged event of the TextMessage control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TextMessage_TextChanged(object sender, EventArgs e)
        {
            if (StegEncode == null)
                return;
            if (this.StegEncode.PixelLoaded)
            {
                LblCharacterCount.Text = String.Format("Characters: {0}/{1}", TextMessage.Text.Length, StegEncode.MaxCharacters);
            }
        }
    }
}