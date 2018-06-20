using Library.Image;
using Library.Utility;
using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
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
        /// Initializes a new instance of the <see cref="EncodeForm" /> class.
        /// </summary>
        public EncodeForm()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            PictureSelectFile.Image = Properties.Resources.Error;
            PictureBoxBase64.Image = Properties.Resources.Warning;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="EncodeForm" /> class.
        /// </summary>
        /// <param name="spawnLoc">The spawn loc.</param>
        /// <param name="eProg">The e prog.</param>
        public EncodeForm(Point spawnLoc, StegoEncode stegEncode)
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = spawnLoc;

            PictureSelectFile.Image = Properties.Resources.Error;
            PictureBoxBase64.Image = Properties.Resources.Warning;

            if (stegEncode == null)
                return;

            this.StegEncode = stegEncode;
            this.StegEncode.OutputFile = stegEncode.OutputFile;
            if (stegEncode.FilePath != null)
                LblFile.Text = stegEncode.FilePath;

            // Fixes icon for PictureSelectFile
            if (this.StegEncode.PixelLoaded)
            {
                PictureSelectFile.Image = Properties.Resources.Ready;
            }
            else
            {
                LoadFile(this.StegEncode.FilePath);
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
            DecodeForm d = new DecodeForm(this.Location, StegEncode);
            d.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the MenuStripSettingsForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MenuStripSettingsForm_Click(object sender, EventArgs e)
        {
            SettingsForm sForm = new SettingsForm
            {
                StartPosition = FormStartPosition.CenterParent
            };
            sForm.ShowDialog();
        }


        /// <summary>
        /// Handles the Click event of the BtnEncode control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private async void BtnEncodeAsync_ClickAsync(object sender, EventArgs e)
        {
            if (!BtnEncodeReady())
                return;

            string message = TextMessage.Text;

            if (CheckBoxBase64.Checked)
                message = Converter.AsciiToBase64(message);

            if (CheckBoxAes.Checked)
            {
                message = Crypto.Encrypt(message, TextBoxAesKey.Text);
                if(message == null)
                {
                    MessageBox.Show(String.Format("{0} is not a valid hash type", Settings.Hash));
                    return;
                }
            }
            BtnEncode.Enabled = false;

            // Set up progress report
            TimerProgress.Start();
            ProgressBarEncode.Maximum = StegEncode.MaxCharacters * 8;
            ProgressBarEncode.Value = 0;

            Task tEncode = new Task(() => StegEncode.CreateImage(message, StegEncode.OutputFile));
            tEncode.Start();
            await Task.WhenAll(tEncode);

            BtnEncode.Enabled = true;
            ProgressBarEncode.Value = ProgressBarEncode.Maximum;
            TimerProgress.Stop();
        }

        /// <summary>
        /// Checks if user inputted everything necessary for encoding
        /// </summary>
        /// <returns></returns>
        private bool BtnEncodeReady()
        {
            if (StegEncode == null)
            {
                MessageBox.Show("You haven't inputted anything...");
                return false;
            }

            string message = TextMessage.Text;

            if (!StegEncode.PixelLoaded)
            {
                MessageBox.Show("Wait for the image to load");
                return false;
            }

            if (message.Length <= 0)
            {
                MessageBox.Show("You have to type some text to hide");
                return false;
            }
            if (StegEncode.OutputFile == null)
            {
                MessageBox.Show("You have to select an output file");
                return false;
            }

            if ((Constants.MessageLength * 8) + message.Length > StegEncode.MaxCharacters)
            {
                MessageBox.Show("Your hidden message is too long");
                return false;
            }

            if (CheckBoxAes.Checked)
            {
                if(TextBoxAesKey.Text.Length <= 0)
                {
                    MessageBox.Show("Please enter your aes key");
                    return false;
                }
            }

            if (File.Exists(this.StegEncode.OutputFile))
            {
                DialogResult dr = MessageBox.Show("this file already exists, do you want to override?", "File Exists",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                    File.Delete(this.StegEncode.OutputFile);
                else
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Handles the Tick event of the TimerProgress control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TimerProgress_Tick(object sender, EventArgs e)
        {
            ProgressBarEncode.Value = StegEncode.EncodeProgress;
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
        /// Handles the Click event of the BtnSelectFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = Constants.ImageFileFilter;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    LoadFile(ofd.FileName);
                }
            }
        }

        /// <summary>
        /// Loads the selected file
        /// </summary>
        private async void LoadFile(string file)
        {
            if(StegEncode == null)
            {
                StegEncode = new StegoEncode(file);
            }
            LblFile.Text = StegEncode.FilePath;
            PictureSelectFile.Image = Properties.Resources.Loading;
            await Task.Run(() => StegEncode.StartLoadingPixelsAsync());
            PictureSelectFile.Image = Properties.Resources.Ready;
        }

        /// <summary>
        /// Handles the TextChanged event of the TextMessage control.
        /// Handles the CheckBoxBase64_CheckedChanged control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TextMessage_TextChanged(object sender, EventArgs e)
        {
            if (StegEncode == null)
                return;

            if (StegEncode.PixelLoaded)
            {
                string text = TextMessage.Text;
                if (CheckBoxBase64.Checked)
                {
                    text = Converter.AsciiToBase64(text);
                }
                if (CheckBoxAes.Checked)
                {
                    text = Crypto.Encrypt(text, "filler");
                    if (text == null)
                        return;
                }
                int characters = (Constants.MessageLength * 8) + text.Length;
                LblCharacterCount.Text = String.Format("Characters: {0}/{1}", characters , StegEncode.MaxCharacters);
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of the CheckBoxAes control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CheckBoxAes_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxAesKey.Enabled = CheckBoxAes.Checked;
            TextMessage_TextChanged(null, null);
        }

        /// <summary>
        /// Handles the CheckedChanged event of the CheckBoxBase64 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CheckBoxBase64_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxBase64.Checked)
            {
                PictureBoxBase64.Enabled = false;
                PictureBoxBase64.Visible = false;
            }
            else
            {
                PictureBoxBase64.Enabled = true;
                PictureBoxBase64.Visible = true;
            }

            TextMessage_TextChanged(null, null);
        }
    }
}