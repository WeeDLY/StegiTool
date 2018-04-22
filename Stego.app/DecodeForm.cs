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
        private StegoDecode SDecode;

        /// <summary>
        /// The encode prog
        /// </summary>
        private EncodeFormProgress EncodeProg;

        /// <summary>
        /// Initializes a new instance of the <see cref="DecodeForm"/> class.
        /// </summary>
        /// <param name="loc">The loc.</param>
        /// <param name="EncodeProg">The encode prog.</param>
        public DecodeForm(Point loc, EncodeFormProgress EncodeProg)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = loc;
            this.EncodeProg = EncodeProg;
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the MenuStripEncodeForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MenuStripEncodeForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            EncodeForm eForm = new EncodeForm(this.Location, EncodeProg);
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
                    SDecode = new StegoDecode(ofd.FileName);
                    LblFile.Text = SDecode.FilePath;
                }
                else
                {
                    return;
                }
            }
        }
    }
}