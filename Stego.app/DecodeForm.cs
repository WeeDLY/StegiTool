using Library.Image;
using Library.Utility;
using System;
using System.Drawing;
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
        public DecodeForm(Point loc, StegoDecode stegDecode, StegoEncode stegEncode)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = loc;

            Initialize(stegDecode, stegEncode);
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        /// <param name="stegDecode">The steg decode.</param>
        /// <param name="stegEncode">The steg encode.</param>
        private void Initialize(StegoDecode stegDecode, StegoEncode stegEncode)
        {
            this.StegEncode = stegEncode;

            if (stegDecode == null)
                return;

            this.StegDecode = stegDecode;
            if (StegDecode.FilePath != null)
                LblFile.Text = StegDecode.FilePath;

        }

        /// <summary>
        /// Handles the Click event of the MenuStripEncodeForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MenuStripEncodeForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            EncodeForm eForm = new EncodeForm(this.Location, StegEncode, StegDecode);
            eForm.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the BtnSelectFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = Constants.ImageFileFilter;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    StegDecode = new StegoDecode(ofd.FileName);
                    LblFile.Text = StegDecode.FilePath;
                }
                else
                {
                    return;
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the BtnDecode control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnDecode_Click(object sender, EventArgs e)
        {
            if(StegDecode == null)
            {
                return;
            }

            /*
             * BIGGEST PROBLEM WITH BASE64, is to determine, what is base64
             * This regex, will find base64 encoded text
             * ^([A-Za-z0-9+/]{4})*([A-Za-z0-9+/]{4}|[A-Za-z0-9+/]{3}=|[A-Za-z0-9+/]{2}==)$
             */

            string message = StegDecode.ReadImage();

            bool base64 = CheckBoxBase64.Checked;
            if (base64)
            {
                message = Converter.Base64ToAscii(message);
            }
            TextOutput.Text = message;
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
    }
}
 