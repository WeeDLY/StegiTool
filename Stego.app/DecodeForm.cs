using Library.Image;
using Library.Utility;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stego.app
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class DecodeForm : Form
    {
        /// <summary>
        /// The s decode
        /// </summary>
        private StegoDecode StegDecode;

        /// <summary>
        /// The encode prog
        /// </summary>
        private StegoEncode StegEncode;

        /// <summary>
        /// Initializes a new instance of the <see cref="DecodeForm"/> class.
        /// </summary>
        /// <param name="loc">The loc.</param>
        /// <param name="EncodeProg">The encode prog.</param>
        public DecodeForm(Point loc, StegoEncode stegEncode)
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = loc;

            this.StegEncode = stegEncode;
        }

        /// <summary>
        /// Handles the Click event of the MenuStripEncodeForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MenuStripEncodeForm_Click(object sender, EventArgs e)
        {
            if(this.StegDecode != null)
                this.StegDecode.DisposeImage();

            this.Hide();
            EncodeForm eForm = new EncodeForm(this.Location, StegEncode);
            eForm.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the MenuStripSettingsForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MenuStripSettingsForm_Click(object sender, EventArgs e)
        {
            SettingsForm sForm = new SettingsForm()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            sForm.ShowDialog();
        }


        /// <summary>
        /// Handles the Click event of the BtnDecode control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private async void BtnDecode_ClickAsync(object sender, EventArgs e)
        {
            if(BtnDecodeReady() == false)
            {
                return;
            }

            int charLength = (int)StegDecode.GetCharactersToRead();
            string password = TextBoxAesPassword.Text;

            // Set up progress report
            TimerProgress.Start();
            BtnDecode.Enabled = false;
            ProgressBarDecode.Maximum = charLength * 8;
            ProgressBarDecode.Value = 0;

            string message = await Task.Run(() => StegDecode.ReadImage());

            if (CheckBoxAes.Checked)
                message = Crypto.Decrypt(message, password);

            if (CheckBoxBase64.Checked)
                message = Converter.Base64ToAscii(message);
            TextOutput.Text = message;

            BtnDecode.Enabled = true;
            ProgressBarDecode.Value = ProgressBarDecode.Maximum;
            TimerProgress.Stop();
        }

        /// <summary>
        /// BTNs the decode ready.
        /// </summary>
        /// <returns></returns>
        private bool BtnDecodeReady()
        {
            if (StegDecode == null)
            {
                MessageBox.Show("You haven't inputted anything...");
                return false;
            }

            if (CheckBoxAes.Checked)
            {
                if (TextBoxAesPassword.Text.Length <= 0)
                {
                    MessageBox.Show("You have to select a password for aes encryption");
                    return false;
                }
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
            ProgressBarDecode.Value = StegDecode.DecodeProgress;
        }


        /// <summary>
        /// Handles the Click event of the BtnClear control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            TextOutput.Text = String.Empty;
        }

        /// <summary>
        /// Handles the Click event of the BtnSelectFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private async void BtnSelectFile_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = Constants.ImageFileFilter;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    StegDecode = new StegoDecode(ofd.FileName);
                    LblFile.Text = StegDecode.FilePath;

                    PictureSelectFile.Image = Properties.Resources.Loading;
                    await Task.Run(() => StegDecode.StartLoadingPixelsAsync());
                    PictureSelectFile.Image = Properties.Resources.Ready;

                }
                else
                {
                    return;
                }
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of the CheckBoxAes control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CheckBoxAes_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxAesPassword.Enabled = CheckBoxAes.Checked;
        }
    }
}