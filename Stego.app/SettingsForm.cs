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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            NumericIterations.Value = Settings.Iterations;
            TextBoxKeySize.Text = Settings.KeySize.ToString();
            TextBoxHash.Text = Settings.Hash;
            TextBoxSalt.Text = Settings.Salt;
            TextBoxVector.Text = Settings.Vector;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }
    }
}