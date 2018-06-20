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
            this.BtnSave = new System.Windows.Forms.Button();
            this.NumericIterations = new System.Windows.Forms.NumericUpDown();
            this.TextBoxKeySize = new System.Windows.Forms.TextBox();
            this.TextBoxHash = new System.Windows.Forms.TextBox();
            this.TextBoxSalt = new System.Windows.Forms.TextBox();
            this.TextBoxVector = new System.Windows.Forms.TextBox();
            this.BtnResetSettings = new System.Windows.Forms.Button();
            this.LblHashIterations = new System.Windows.Forms.Label();
            this.LblKeySize = new System.Windows.Forms.Label();
            this.LblHashType = new System.Windows.Forms.Label();
            this.LblSalt = new System.Windows.Forms.Label();
            this.LblVector = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericIterations)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(15, 147);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // NumericIterations
            // 
            this.NumericIterations.Location = new System.Drawing.Point(118, 9);
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
            2,
            0,
            0,
            0});
            // 
            // TextBoxKeySize
            // 
            this.TextBoxKeySize.Location = new System.Drawing.Point(118, 36);
            this.TextBoxKeySize.Name = "TextBoxKeySize";
            this.TextBoxKeySize.Size = new System.Drawing.Size(153, 20);
            this.TextBoxKeySize.TabIndex = 3;
            // 
            // TextBoxHash
            // 
            this.TextBoxHash.Location = new System.Drawing.Point(118, 62);
            this.TextBoxHash.Name = "TextBoxHash";
            this.TextBoxHash.Size = new System.Drawing.Size(153, 20);
            this.TextBoxHash.TabIndex = 4;
            // 
            // TextBoxSalt
            // 
            this.TextBoxSalt.Location = new System.Drawing.Point(118, 88);
            this.TextBoxSalt.Name = "TextBoxSalt";
            this.TextBoxSalt.Size = new System.Drawing.Size(153, 20);
            this.TextBoxSalt.TabIndex = 5;
            // 
            // TextBoxVector
            // 
            this.TextBoxVector.Location = new System.Drawing.Point(118, 114);
            this.TextBoxVector.Name = "TextBoxVector";
            this.TextBoxVector.Size = new System.Drawing.Size(153, 20);
            this.TextBoxVector.TabIndex = 6;
            // 
            // BtnResetSettings
            // 
            this.BtnResetSettings.Location = new System.Drawing.Point(196, 147);
            this.BtnResetSettings.Name = "BtnResetSettings";
            this.BtnResetSettings.Size = new System.Drawing.Size(75, 23);
            this.BtnResetSettings.TabIndex = 7;
            this.BtnResetSettings.Text = "Reset";
            this.BtnResetSettings.UseVisualStyleBackColor = true;
            this.BtnResetSettings.Click += new System.EventHandler(this.BtnResetSettings_Click);
            // 
            // LblHashIterations
            // 
            this.LblHashIterations.Location = new System.Drawing.Point(12, 9);
            this.LblHashIterations.Name = "LblHashIterations";
            this.LblHashIterations.Size = new System.Drawing.Size(100, 16);
            this.LblHashIterations.TabIndex = 8;
            this.LblHashIterations.Text = "Hash iterations";
            this.LblHashIterations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblKeySize
            // 
            this.LblKeySize.Location = new System.Drawing.Point(12, 36);
            this.LblKeySize.Name = "LblKeySize";
            this.LblKeySize.Size = new System.Drawing.Size(100, 16);
            this.LblKeySize.TabIndex = 9;
            this.LblKeySize.Text = "Key Size";
            this.LblKeySize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblHashType
            // 
            this.LblHashType.Location = new System.Drawing.Point(12, 62);
            this.LblHashType.Name = "LblHashType";
            this.LblHashType.Size = new System.Drawing.Size(100, 16);
            this.LblHashType.TabIndex = 10;
            this.LblHashType.Text = "Hash Type";
            this.LblHashType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblSalt
            // 
            this.LblSalt.Location = new System.Drawing.Point(12, 89);
            this.LblSalt.Name = "LblSalt";
            this.LblSalt.Size = new System.Drawing.Size(100, 16);
            this.LblSalt.TabIndex = 11;
            this.LblSalt.Text = "Salt";
            this.LblSalt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblVector
            // 
            this.LblVector.Location = new System.Drawing.Point(12, 115);
            this.LblVector.Name = "LblVector";
            this.LblVector.Size = new System.Drawing.Size(100, 16);
            this.LblVector.TabIndex = 12;
            this.LblVector.Text = "Vector";
            this.LblVector.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 177);
            this.Controls.Add(this.LblVector);
            this.Controls.Add(this.LblSalt);
            this.Controls.Add(this.LblHashType);
            this.Controls.Add(this.LblKeySize);
            this.Controls.Add(this.LblHashIterations);
            this.Controls.Add(this.BtnResetSettings);
            this.Controls.Add(this.TextBoxVector);
            this.Controls.Add(this.TextBoxSalt);
            this.Controls.Add(this.TextBoxHash);
            this.Controls.Add(this.TextBoxKeySize);
            this.Controls.Add(this.NumericIterations);
            this.Controls.Add(this.BtnSave);
            this.Name = "SettingsForm";
            this.Text = "StegiTool - Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericIterations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.NumericUpDown NumericIterations;
        private System.Windows.Forms.TextBox TextBoxKeySize;
        private System.Windows.Forms.TextBox TextBoxHash;
        private System.Windows.Forms.TextBox TextBoxSalt;
        private System.Windows.Forms.TextBox TextBoxVector;
        private System.Windows.Forms.Button BtnResetSettings;
        private System.Windows.Forms.Label LblHashIterations;
        private System.Windows.Forms.Label LblKeySize;
        private System.Windows.Forms.Label LblHashType;
        private System.Windows.Forms.Label LblSalt;
        private System.Windows.Forms.Label LblVector;
    }
}