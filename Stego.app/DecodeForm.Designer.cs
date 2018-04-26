namespace Stego.app
{
    partial class DecodeForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuStripEncodeForm = new System.Windows.Forms.ToolStripMenuItem();
            this.decodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripSettingsForm = new System.Windows.Forms.ToolStripMenuItem();
            this.LblFile = new System.Windows.Forms.Label();
            this.BtnSelectFile = new System.Windows.Forms.Button();
            this.TextOutput = new System.Windows.Forms.RichTextBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDecode = new System.Windows.Forms.Button();
            this.CheckBoxBase64 = new System.Windows.Forms.CheckBox();
            this.checkBoxAes = new System.Windows.Forms.CheckBox();
            this.TextBoxAesPassword = new System.Windows.Forms.TextBox();
            this.NumericChars = new System.Windows.Forms.NumericUpDown();
            this.ProgressBarDecode = new System.Windows.Forms.ProgressBar();
            this.TimerProgress = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericChars)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripEncodeForm,
            this.decodeToolStripMenuItem,
            this.MenuStripSettingsForm});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuStripEncodeForm
            // 
            this.MenuStripEncodeForm.Name = "MenuStripEncodeForm";
            this.MenuStripEncodeForm.Size = new System.Drawing.Size(58, 20);
            this.MenuStripEncodeForm.Text = "Encode";
            this.MenuStripEncodeForm.Click += new System.EventHandler(this.MenuStripEncodeForm_Click);
            // 
            // decodeToolStripMenuItem
            // 
            this.decodeToolStripMenuItem.Name = "decodeToolStripMenuItem";
            this.decodeToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.decodeToolStripMenuItem.Text = "Decode";
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
            this.LblFile.Size = new System.Drawing.Size(188, 23);
            this.LblFile.TabIndex = 12;
            this.LblFile.Text = "<Selected File>";
            this.LblFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnSelectFile
            // 
            this.BtnSelectFile.Location = new System.Drawing.Point(12, 27);
            this.BtnSelectFile.Name = "BtnSelectFile";
            this.BtnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.BtnSelectFile.TabIndex = 11;
            this.BtnSelectFile.Text = "Select File";
            this.BtnSelectFile.UseVisualStyleBackColor = true;
            this.BtnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
            // 
            // TextOutput
            // 
            this.TextOutput.Location = new System.Drawing.Point(12, 56);
            this.TextOutput.Name = "TextOutput";
            this.TextOutput.ReadOnly = true;
            this.TextOutput.Size = new System.Drawing.Size(269, 301);
            this.TextOutput.TabIndex = 15;
            this.TextOutput.Text = "";
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(12, 363);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 16;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnDecode
            // 
            this.BtnDecode.Location = new System.Drawing.Point(390, 265);
            this.BtnDecode.Name = "BtnDecode";
            this.BtnDecode.Size = new System.Drawing.Size(75, 20);
            this.BtnDecode.TabIndex = 17;
            this.BtnDecode.Text = "Decode";
            this.BtnDecode.UseVisualStyleBackColor = true;
            this.BtnDecode.Click += new System.EventHandler(this.BtnDecode_ClickAsync);
            // 
            // CheckBoxBase64
            // 
            this.CheckBoxBase64.AutoSize = true;
            this.CheckBoxBase64.Location = new System.Drawing.Point(287, 131);
            this.CheckBoxBase64.Name = "CheckBoxBase64";
            this.CheckBoxBase64.Size = new System.Drawing.Size(65, 17);
            this.CheckBoxBase64.TabIndex = 18;
            this.CheckBoxBase64.Text = "Base 64";
            this.CheckBoxBase64.UseVisualStyleBackColor = true;
            // 
            // checkBoxAes
            // 
            this.checkBoxAes.AutoSize = true;
            this.checkBoxAes.Location = new System.Drawing.Point(287, 163);
            this.checkBoxAes.Name = "checkBoxAes";
            this.checkBoxAes.Size = new System.Drawing.Size(47, 17);
            this.checkBoxAes.TabIndex = 19;
            this.checkBoxAes.Text = "AES";
            this.checkBoxAes.UseVisualStyleBackColor = true;
            // 
            // TextBoxAesPassword
            // 
            this.TextBoxAesPassword.Location = new System.Drawing.Point(285, 186);
            this.TextBoxAesPassword.Name = "TextBoxAesPassword";
            this.TextBoxAesPassword.Size = new System.Drawing.Size(357, 20);
            this.TextBoxAesPassword.TabIndex = 20;
            // 
            // NumericChars
            // 
            this.NumericChars.Location = new System.Drawing.Point(301, 67);
            this.NumericChars.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NumericChars.Name = "NumericChars";
            this.NumericChars.Size = new System.Drawing.Size(102, 20);
            this.NumericChars.TabIndex = 21;
            this.NumericChars.ThousandsSeparator = true;
            this.NumericChars.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ProgressBarDecode
            // 
            this.ProgressBarDecode.Location = new System.Drawing.Point(285, 334);
            this.ProgressBarDecode.Name = "ProgressBarDecode";
            this.ProgressBarDecode.Size = new System.Drawing.Size(357, 23);
            this.ProgressBarDecode.TabIndex = 22;
            // 
            // TimerProgress
            // 
            this.TimerProgress.Interval = 1000;
            this.TimerProgress.Tick += new System.EventHandler(this.TimerProgress_Tick);
            // 
            // DecodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 398);
            this.Controls.Add(this.ProgressBarDecode);
            this.Controls.Add(this.NumericChars);
            this.Controls.Add(this.TextBoxAesPassword);
            this.Controls.Add(this.checkBoxAes);
            this.Controls.Add(this.CheckBoxBase64);
            this.Controls.Add(this.BtnDecode);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.TextOutput);
            this.Controls.Add(this.LblFile);
            this.Controls.Add(this.BtnSelectFile);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DecodeForm";
            this.Text = "StegiTool - Decode";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericChars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuStripEncodeForm;
        private System.Windows.Forms.ToolStripMenuItem decodeToolStripMenuItem;
        private System.Windows.Forms.Label LblFile;
        private System.Windows.Forms.Button BtnSelectFile;
        private System.Windows.Forms.RichTextBox TextOutput;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDecode;
        private System.Windows.Forms.CheckBox CheckBoxBase64;
        private System.Windows.Forms.CheckBox checkBoxAes;
        private System.Windows.Forms.TextBox TextBoxAesPassword;
        private System.Windows.Forms.NumericUpDown NumericChars;
        private System.Windows.Forms.ProgressBar ProgressBarDecode;
        private System.Windows.Forms.Timer TimerProgress;
        private System.Windows.Forms.ToolStripMenuItem MenuStripSettingsForm;
    }
}