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
            this.menuStrip1.SuspendLayout();
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
            this.BtnEncode.Location = new System.Drawing.Point(287, 305);
            this.BtnEncode.Name = "BtnEncode";
            this.BtnEncode.Size = new System.Drawing.Size(357, 23);
            this.BtnEncode.TabIndex = 3;
            this.BtnEncode.Text = "Encode";
            this.BtnEncode.UseVisualStyleBackColor = true;
            this.BtnEncode.Click += new System.EventHandler(this.BtnEncodeAsync_ClickAsync);
            // 
            // TextMessage
            // 
            this.TextMessage.Location = new System.Drawing.Point(12, 82);
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.Size = new System.Drawing.Size(269, 275);
            this.TextMessage.TabIndex = 5;
            this.TextMessage.Text = "";
            this.TextMessage.TextChanged += new System.EventHandler(this.TextMessage_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.MenuStripDecodeForm});
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
            // LblFile
            // 
            this.LblFile.Location = new System.Drawing.Point(93, 27);
            this.LblFile.Name = "LblFile";
            this.LblFile.Size = new System.Drawing.Size(188, 23);
            this.LblFile.TabIndex = 7;
            this.LblFile.Text = "<Selected File>";
            this.LblFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(12, 366);
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
            this.LblOutputFile.Size = new System.Drawing.Size(188, 23);
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
            this.LblCharacterCount.Location = new System.Drawing.Point(93, 366);
            this.LblCharacterCount.Name = "LblCharacterCount";
            this.LblCharacterCount.Size = new System.Drawing.Size(188, 23);
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
            this.ProgressBarEncode.Location = new System.Drawing.Point(287, 334);
            this.ProgressBarEncode.Name = "ProgressBarEncode";
            this.ProgressBarEncode.Size = new System.Drawing.Size(357, 23);
            this.ProgressBarEncode.TabIndex = 12;
            // 
            // CheckBoxBase64
            // 
            this.CheckBoxBase64.AutoSize = true;
            this.CheckBoxBase64.Location = new System.Drawing.Point(309, 84);
            this.CheckBoxBase64.Name = "CheckBoxBase64";
            this.CheckBoxBase64.Size = new System.Drawing.Size(65, 17);
            this.CheckBoxBase64.TabIndex = 13;
            this.CheckBoxBase64.Text = "Base 64";
            this.ToolTipAes.SetToolTip(this.CheckBoxBase64, "After encrypting the text, the result will be base64 encoded, before it\'s hidden " +
        "in the image");
            this.CheckBoxBase64.UseVisualStyleBackColor = true;
            this.CheckBoxBase64.CheckedChanged += new System.EventHandler(this.TextMessage_TextChanged);
            // 
            // CheckBoxAes
            // 
            this.CheckBoxAes.AutoSize = true;
            this.CheckBoxAes.Location = new System.Drawing.Point(309, 123);
            this.CheckBoxAes.Name = "CheckBoxAes";
            this.CheckBoxAes.Size = new System.Drawing.Size(47, 17);
            this.CheckBoxAes.TabIndex = 14;
            this.CheckBoxAes.Text = "AES";
            this.ToolTipAes.SetToolTip(this.CheckBoxAes, "After encrypting the text, the result will be base64 encoded, before it\'s hidden " +
        "in the image");
            this.CheckBoxAes.UseVisualStyleBackColor = true;
            this.CheckBoxAes.CheckedChanged += new System.EventHandler(this.CheckBoxAes_CheckedChanged);
            // 
            // TextBoxAesKey
            // 
            this.TextBoxAesKey.Location = new System.Drawing.Point(309, 146);
            this.TextBoxAesKey.Name = "TextBoxAesKey";
            this.TextBoxAesKey.Size = new System.Drawing.Size(335, 20);
            this.TextBoxAesKey.TabIndex = 15;
            // 
            // ToolTipAes
            // 
            this.ToolTipAes.AutoPopDelay = 5000;
            this.ToolTipAes.InitialDelay = 250;
            this.ToolTipAes.ReshowDelay = 100;
            // 
            // EncodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 398);
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
            this.Text = "StegiTool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

