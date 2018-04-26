namespace Stego.app
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.NumericIterations = new System.Windows.Forms.NumericUpDown();
            this.TextBoxKeySize = new System.Windows.Forms.TextBox();
            this.TextBoxHash = new System.Windows.Forms.TextBox();
            this.TextBoxSalt = new System.Windows.Forms.TextBox();
            this.TextBoxVector = new System.Windows.Forms.TextBox();
            this.BtnResetSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericIterations)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cryptography Settings";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(62, 286);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // NumericIterations
            // 
            this.NumericIterations.Location = new System.Drawing.Point(72, 136);
            this.NumericIterations.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericIterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericIterations.Name = "NumericIterations";
            this.NumericIterations.Size = new System.Drawing.Size(36, 20);
            this.NumericIterations.TabIndex = 2;
            this.NumericIterations.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TextBoxKeySize
            // 
            this.TextBoxKeySize.Location = new System.Drawing.Point(62, 162);
            this.TextBoxKeySize.Name = "TextBoxKeySize";
            this.TextBoxKeySize.Size = new System.Drawing.Size(100, 20);
            this.TextBoxKeySize.TabIndex = 3;
            // 
            // TextBoxHash
            // 
            this.TextBoxHash.Location = new System.Drawing.Point(62, 188);
            this.TextBoxHash.Name = "TextBoxHash";
            this.TextBoxHash.Size = new System.Drawing.Size(100, 20);
            this.TextBoxHash.TabIndex = 4;
            // 
            // TextBoxSalt
            // 
            this.TextBoxSalt.Location = new System.Drawing.Point(62, 214);
            this.TextBoxSalt.Name = "TextBoxSalt";
            this.TextBoxSalt.Size = new System.Drawing.Size(100, 20);
            this.TextBoxSalt.TabIndex = 5;
            // 
            // TextBoxVector
            // 
            this.TextBoxVector.Location = new System.Drawing.Point(62, 240);
            this.TextBoxVector.Name = "TextBoxVector";
            this.TextBoxVector.Size = new System.Drawing.Size(100, 20);
            this.TextBoxVector.TabIndex = 6;
            // 
            // BtnResetSettings
            // 
            this.BtnResetSettings.Location = new System.Drawing.Point(278, 286);
            this.BtnResetSettings.Name = "BtnResetSettings";
            this.BtnResetSettings.Size = new System.Drawing.Size(75, 23);
            this.BtnResetSettings.TabIndex = 7;
            this.BtnResetSettings.Text = "Reset";
            this.BtnResetSettings.UseVisualStyleBackColor = true;
            this.BtnResetSettings.Click += new System.EventHandler(this.BtnResetSettings_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 321);
            this.Controls.Add(this.BtnResetSettings);
            this.Controls.Add(this.TextBoxVector);
            this.Controls.Add(this.TextBoxSalt);
            this.Controls.Add(this.TextBoxHash);
            this.Controls.Add(this.TextBoxKeySize);
            this.Controls.Add(this.NumericIterations);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericIterations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.NumericUpDown NumericIterations;
        private System.Windows.Forms.TextBox TextBoxKeySize;
        private System.Windows.Forms.TextBox TextBoxHash;
        private System.Windows.Forms.TextBox TextBoxSalt;
        private System.Windows.Forms.TextBox TextBoxVector;
        private System.Windows.Forms.Button BtnResetSettings;
    }
}