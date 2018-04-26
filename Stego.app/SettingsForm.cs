using Library.Utility;
using System;
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
            SetInputFields();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int iterations = (int)NumericIterations.Value;
            string keySize = TextBoxKeySize.Text;
            string hash = TextBoxHash.Text;
            string salt = TextBoxSalt.Text;
            string vector = TextBoxVector.Text;

            if (keySize.Length <= 0 || hash.Length <= 0 || salt.Length <= 0 || vector.Length <= 0)
            {
                MessageBox.Show("You have to fill out all fields");
                return;
            }
            bool valid = int.TryParse(keySize, out int key);
            if(!valid)
            {
                MessageBox.Show("Key size have to be a number");
                return;
            }

            Settings.SaveSettings(iterations, key, TextBoxHash.Text, TextBoxSalt.Text, TextBoxVector.Text);
            MessageBox.Show("Settings saved successfully");
        }

        private void BtnResetSettings_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("This will reset your settings to default, are you sure? This is irreversible!",
                                            "Settings Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dr == DialogResult.Yes)
            {
                Settings.ResetToStandard();
                SetInputFields();
            }
        }

        private void SetInputFields()
        {
            NumericIterations.Value = Settings.Iterations;
            TextBoxKeySize.Text = Settings.KeySize.ToString();
            TextBoxHash.Text = Settings.Hash;
            TextBoxSalt.Text = Settings.Salt;
            TextBoxVector.Text = Settings.Vector;
        }
    }
}