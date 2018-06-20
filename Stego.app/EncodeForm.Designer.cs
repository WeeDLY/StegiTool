namespace Stego.app
{
    partial class EncodeForm
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
            this.components = new System.ComponentModel.Container();
            this.BtnSelectFile = new System.Windows.Forms.Button();
            this.BtnEncode = new System.Windows.Forms.Button();
            this.TextMessage = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripDecodeForm = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripSettingsForm = new System.Windows.Forms.ToolStripMenuItem();
            this.LblFile = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.LblOutputFile = new System.Windows.Forms.Label();
            this.BtnSelectOutputFile = new System.Windows.Forms.Button();
            this.LblCharacterCount = new System.Windows.Forms.Label();
            this.TimerProgress = new System.Windows.Forms.Timer(this.components);
            this.ProgressBarEncode = new System.Windows.Forms.ProgressBar();
            this.CheckBoxBase64 = new System.Windows.Forms.CheckBox();
            this.CheckBoxAes = new System.Windows.Forms.CheckBox();
            this.TextBoxAesKey = new System.Windows.Forms.TextBox();
            this.ToolTipAes = new System.Windows.Forms.ToolTip(this.components);
            this.PictureSelectFile = new System.Windows.Forms.PictureBox();
            this.PictureBoxBase64 = new System.Windows.Forms.PictureBox();
            this.ToolTipBase64 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSelectFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBase64)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSelectFile
            // 
            this.BtnSelectFile.Location = new System.Drawing.Point(12, 27);
            this.BtnSelectFile.Name = "BtnSelectFile";
            this.BtnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.BtnSelectFile.TabIndex = 0;
            this.BtnSelectFile.Text = "Select File";
            this.BtnSelectFile.UseVisualStyleBackColor = true;
            this.BtnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
            // 
            // BtnEncode
            // 
            this.BtnEncode.Location = new System.Drawing.Point(406, 224);
            this.BtnEncode.Name = "BtnEncode";
            this.BtnEncode.Size = new System.Drawing.Size(238, 23);
            this.BtnEncode.TabIndex = 3;
            this.BtnEncode.Text = "Encode";
            this.BtnEncode.UseVisualStyleBackColor = true;
            this.BtnEncode.Click += new System.EventHandler(this.BtnEncodeAsync_ClickAsync);
            // 
            // TextMessage
            // 
            this.TextMessage.Location = new System.Drawing.Point(8, 82);
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.Size = new System.Drawing.Size(388, 194);
            this.TextMessage.TabIndex = 5;
            this.TextMessage.Text = "";
            this.TextMessage.TextChanged += new System.EventHandler(this.TextMessage_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.MenuStripDecodeForm,
            this.MenuStripSettingsForm});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.fileToolStripMenuItem.Text = "Encode";
            // 
            // MenuStripDecodeForm
            // 
            this.MenuStripDecodeForm.Name = "MenuStripDecodeForm";
            this.MenuStripDecodeForm.Size = new System.Drawing.Size(59, 20);
            this.MenuStripDecodeForm.Text = "Decode";
            this.MenuStripDecodeForm.Click += new System.EventHandler(this.MenuStripDecodeForm_Click);
            // 
            // MenuStripSettingsForm
            // 
            this.MenuStripSettingsForm.Name = "MenuStripSettingsForm";
            this.MenuStripSettingsForm.Size = new System.Drawing.Size(61, 20);
            this.MenuStripSettingsForm.Text = "Settings";
            this.MenuStripSettingsForm.Click += new System.EventHandler(this.MenuStripSettingsForm_Click);
            // 
            // LblFile
            // 
            this.LblFile.Location = new System.Drawing.Point(93, 27);
            this.LblFile.Name = "LblFile";
            this.LblFile.Size = new System.Drawing.Size(273, 23);
            this.LblFile.TabIndex = 7;
            this.LblFile.Text = "<Selected File>";
            this.LblFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(12, 282);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 8;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // LblOutputFile
            // 
            this.LblOutputFile.Location = new System.Drawing.Point(93, 56);
            this.LblOutputFile.Name = "LblOutputFile";
            this.LblOutputFile.Size = new System.Drawing.Size(273, 23);
            this.LblOutputFile.TabIndex = 9;
            this.LblOutputFile.Text = "<Output File>";
            this.LblOutputFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnSelectOutputFile
            // 
            this.BtnSelectOutputFile.Location = new System.Drawing.Point(12, 56);
            this.BtnSelectOutputFile.Name = "BtnSelectOutputFile";
            this.BtnSelectOutputFile.Size = new System.Drawing.Size(75, 23);
            this.BtnSelectOutputFile.TabIndex = 10;
            this.BtnSelectOutputFile.Text = "Select File";
            this.BtnSelectOutputFile.UseVisualStyleBackColor = true;
            this.BtnSelectOutputFile.Click += new System.EventHandler(this.BtnSelectOutputFile_Click);
            // 
            // LblCharacterCount
            // 
            this.LblCharacterCount.Location = new System.Drawing.Point(93, 282);
            this.LblCharacterCount.Name = "LblCharacterCount";
            this.LblCharacterCount.Size = new System.Drawing.Size(303, 23);
            this.LblCharacterCount.TabIndex = 11;
            this.LblCharacterCount.Text = "Characters: 0/0";
            this.LblCharacterCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimerProgress
            // 
            this.TimerProgress.Interval = 1000;
            this.TimerProgress.Tick += new System.EventHandler(this.TimerProgress_Tick);
            // 
            // ProgressBarEncode
            // 
            this.ProgressBarEncode.Location = new System.Drawing.Point(406, 253);
            this.ProgressBarEncode.Name = "ProgressBarEncode";
            this.ProgressBarEncode.Size = new System.Drawing.Size(238, 23);
            this.ProgressBarEncode.TabIndex = 12;
            // 
            // CheckBoxBase64
            // 
            this.CheckBoxBase64.Checked = true;
            this.CheckBoxBase64.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxBase64.Location = new System.Drawing.Point(406, 84);
            this.CheckBoxBase64.Name = "CheckBoxBase64";
            this.CheckBoxBase64.Size = new System.Drawing.Size(65, 24);
            this.CheckBoxBase64.TabIndex = 13;
            this.CheckBoxBase64.Text = "Base 64";
            this.CheckBoxBase64.UseVisualStyleBackColor = true;
            this.CheckBoxBase64.CheckedChanged += new System.EventHandler(this.CheckBoxBase64_CheckedChanged);
            // 
            // CheckBoxAes
            // 
            this.CheckBoxAes.Location = new System.Drawing.Point(406, 114);
            this.CheckBoxAes.Name = "CheckBoxAes";
            this.CheckBoxAes.Size = new System.Drawing.Size(47, 24);
            this.CheckBoxAes.TabIndex = 14;
            this.CheckBoxAes.Text = "AES";
            this.ToolTipAes.SetToolTip(this.CheckBoxAes, "After encrypting the text, the result will be base64 encoded, before it\'s hidden " +
        "in the image");
            this.CheckBoxAes.UseVisualStyleBackColor = true;
            this.CheckBoxAes.CheckedChanged += new System.EventHandler(this.CheckBoxAes_CheckedChanged);
            // 
            // TextBoxAesKey
            // 
            this.TextBoxAesKey.Enabled = false;
            this.TextBoxAesKey.Location = new System.Drawing.Point(406, 144);
            this.TextBoxAesKey.Name = "TextBoxAesKey";
            this.TextBoxAesKey.Size = new System.Drawing.Size(238, 20);
            this.TextBoxAesKey.TabIndex = 15;
            // 
            // ToolTipAes
            // 
            this.ToolTipAes.AutoPopDelay = 5000;
            this.ToolTipAes.InitialDelay = 250;
            this.ToolTipAes.ReshowDelay = 100;
            // 
            // PictureSelectFile
            // 
            this.PictureSelectFile.BackColor = System.Drawing.SystemColors.Control;
            this.PictureSelectFile.Location = new System.Drawing.Point(372, 26);
            this.PictureSelectFile.Name = "PictureSelectFile";
            this.PictureSelectFile.Size = new System.Drawing.Size(24, 24);
            this.PictureSelectFile.TabIndex = 16;
            this.PictureSelectFile.TabStop = false;
            // 
            // PictureBoxBase64
            // 
            this.PictureBoxBase64.BackColor = System.Drawing.SystemColors.Control;
            this.PictureBoxBase64.Enabled = false;
            this.PictureBoxBase64.Location = new System.Drawing.Point(477, 82);
            this.PictureBoxBase64.Name = "PictureBoxBase64";
            this.PictureBoxBase64.Size = new System.Drawing.Size(24, 24);
            this.PictureBoxBase64.TabIndex = 17;
            this.PictureBoxBase64.TabStop = false;
            this.ToolTipBase64.SetToolTip(this.PictureBoxBase64, "Some special characters may not work without being base64 encoded!");
            this.PictureBoxBase64.Visible = false;
            // 
            // ToolTipBase64
            // 
            this.ToolTipBase64.AutoPopDelay = 5000;
            this.ToolTipBase64.InitialDelay = 250;
            this.ToolTipBase64.ReshowDelay = 100;
            // 
            // EncodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 311);
            this.Controls.Add(this.PictureBoxBase64);
            this.Controls.Add(this.PictureSelectFile);
            this.Controls.Add(this.TextBoxAesKey);
            this.Controls.Add(this.CheckBoxAes);
            this.Controls.Add(this.CheckBoxBase64);
            this.Controls.Add(this.ProgressBarEncode);
            this.Controls.Add(this.LblCharacterCount);
            this.Controls.Add(this.BtnSelectOutputFile);
            this.Controls.Add(this.LblOutputFile);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.LblFile);
            this.Controls.Add(this.TextMessage);
            this.Controls.Add(this.BtnEncode);
            this.Controls.Add(this.BtnSelectFile);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EncodeForm";
            this.Text = "StegiTool - Encode";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSelectFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBase64)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSelectFile;
        private System.Windows.Forms.Button BtnEncode;
        private System.Windows.Forms.RichTextBox TextMessage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label LblFile;
        private System.Windows.Forms.ToolStripMenuItem MenuStripDecodeForm;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label LblOutputFile;
        private System.Windows.Forms.Button BtnSelectOutputFile;
        private System.Windows.Forms.Label LblCharacterCount;
        private System.Windows.Forms.Timer TimerProgress;
        private System.Windows.Forms.ProgressBar ProgressBarEncode;
        private System.Windows.Forms.CheckBox CheckBoxBase64;
        private System.Windows.Forms.CheckBox CheckBoxAes;
        private System.Windows.Forms.TextBox TextBoxAesKey;
        private System.Windows.Forms.ToolTip ToolTipAes;
        private System.Windows.Forms.ToolStripMenuItem MenuStripSettingsForm;
        private System.Windows.Forms.PictureBox PictureSelectFile;
        private System.Windows.Forms.PictureBox PictureBoxBase64;
        private System.Windows.Forms.ToolTip ToolTipBase64;
    }
}

