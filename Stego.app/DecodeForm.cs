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
    public partial class DecodeForm : Form
    {
        private EncodeFormProgress EncodeProg;

        public DecodeForm(Point loc, EncodeFormProgress EncodeProg)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = loc;
            this.EncodeProg = EncodeProg;
            InitializeComponent();
        }

        private void MenuStripEncodeForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            EncodeForm eForm = new EncodeForm(this.Location, EncodeProg);
            eForm.ShowDialog();
            this.Close();
        }
    }
}