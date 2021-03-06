﻿namespace Stego.app
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
            this.BtnDecode = new System.Windows.Forms.Button();
            this.CheckBoxBase64 = new System.Windows.Forms.CheckBox();
            this.CheckBoxAes = new System.Windows.Forms.CheckBox();
            this.TextBoxAesPassword = new System.Windows.Forms.TextBox();
            this.ProgressBarDecode = new System.Windows.Forms.ProgressBar();
            this.TimerProgress = new System.Windows.Forms.Timer(this.components);
            this.PictureSelectFile = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSelectFile)).BeginInit();
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
            this.LblFile.Size = new System.Drawing.Size(273, 23);
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
            this.TextOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextOutput.Location = new System.Drawing.Point(8, 56);
            this.TextOutput.Name = "TextOutput";
            this.TextOutput.ReadOnly = true;
            this.TextOutput.Size = new System.Drawing.Size(388, 243);
            this.TextOutput.TabIndex = 15;
            this.TextOutput.Text = "";
            // 
            // BtnDecode
            // 
            this.BtnDecode.Location = new System.Drawing.Point(402, 247);
            this.BtnDecode.Name = "BtnDecode";
            this.BtnDecode.Size = new System.Drawing.Size(242, 23);
            this.BtnDecode.TabIndex = 17;
            this.BtnDecode.Text = "Decode";
            this.BtnDecode.UseVisualStyleBackColor = true;
            this.BtnDecode.Click += new System.EventHandler(this.BtnDecode_ClickAsync);
            // 
            // CheckBoxBase64
            // 
            this.CheckBoxBase64.AutoSize = true;
            this.CheckBoxBase64.Checked = true;
            this.CheckBoxBase64.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxBase64.Location = new System.Drawing.Point(402, 58);
            this.CheckBoxBase64.Name = "CheckBoxBase64";
            this.CheckBoxBase64.Size = new System.Drawing.Size(65, 17);
            this.CheckBoxBase64.TabIndex = 18;
            this.CheckBoxBase64.Text = "Base 64";
            this.CheckBoxBase64.UseVisualStyleBackColor = true;
            // 
            // CheckBoxAes
            // 
            this.CheckBoxAes.AutoSize = true;
            this.CheckBoxAes.Location = new System.Drawing.Point(402, 81);
            this.CheckBoxAes.Name = "CheckBoxAes";
            this.CheckBoxAes.Size = new System.Drawing.Size(47, 17);
            this.CheckBoxAes.TabIndex = 19;
            this.CheckBoxAes.Text = "AES";
            this.CheckBoxAes.UseVisualStyleBackColor = true;
            this.CheckBoxAes.CheckedChanged += new System.EventHandler(this.CheckBoxAes_CheckedChanged);
            // 
            // TextBoxAesPassword
            // 
            this.TextBoxAesPassword.Enabled = false;
            this.TextBoxAesPassword.Location = new System.Drawing.Point(400, 104);
            this.TextBoxAesPassword.Name = "TextBoxAesPassword";
            this.TextBoxAesPassword.Size = new System.Drawing.Size(244, 20);
            this.TextBoxAesPassword.TabIndex = 20;
            // 
            // ProgressBarDecode
            // 
            this.ProgressBarDecode.Location = new System.Drawing.Point(402, 276);
            this.ProgressBarDecode.Name = "ProgressBarDecode";
            this.ProgressBarDecode.Size = new System.Drawing.Size(242, 23);
            this.ProgressBarDecode.TabIndex = 22;
            // 
            // TimerProgress
            // 
            this.TimerProgress.Interval = 1000;
            this.TimerProgress.Tick += new System.EventHandler(this.TimerProgress_Tick);
            // 
            // PictureSelectFile
            // 
            this.PictureSelectFile.Location = new System.Drawing.Point(372, 26);
            this.PictureSelectFile.Name = "PictureSelectFile";
            this.PictureSelectFile.Size = new System.Drawing.Size(24, 24);
            this.PictureSelectFile.TabIndex = 23;
            this.PictureSelectFile.TabStop = false;
            // 
            // DecodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 311);
            this.Controls.Add(this.PictureSelectFile);
            this.Controls.Add(this.ProgressBarDecode);
            this.Controls.Add(this.TextBoxAesPassword);
            this.Controls.Add(this.CheckBoxAes);
            this.Controls.Add(this.CheckBoxBase64);
            this.Controls.Add(this.BtnDecode);
            this.Controls.Add(this.TextOutput);
            this.Controls.Add(this.LblFile);
            this.Controls.Add(this.BtnSelectFile);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DecodeForm";
            this.Text = "StegiTool - Decode";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSelectFile)).EndInit();
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
        private System.Windows.Forms.Button BtnDecode;
        private System.Windows.Forms.CheckBox CheckBoxBase64;
        private System.Windows.Forms.CheckBox CheckBoxAes;
        private System.Windows.Forms.TextBox TextBoxAesPassword;
        private System.Windows.Forms.ProgressBar ProgressBarDecode;
        private System.Windows.Forms.Timer TimerProgress;
        private System.Windows.Forms.ToolStripMenuItem MenuStripSettingsForm;
        private System.Windows.Forms.PictureBox PictureSelectFile;
    }
}