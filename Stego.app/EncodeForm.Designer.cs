﻿namespace Stego.app
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
            this.BtnSelectFile = new System.Windows.Forms.Button();
            this.BtnEncode = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TextMessage = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblFile = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.LblOutputFile = new System.Windows.Forms.Label();
            this.BtnSelectOutputFile = new System.Windows.Forms.Button();
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
            this.BtnEncode.Location = new System.Drawing.Point(307, 72);
            this.BtnEncode.Name = "BtnEncode";
            this.BtnEncode.Size = new System.Drawing.Size(75, 23);
            this.BtnEncode.TabIndex = 3;
            this.BtnEncode.Text = "Encode";
            this.BtnEncode.UseVisualStyleBackColor = true;
            this.BtnEncode.Click += new System.EventHandler(this.BtnEncode_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextMessage
            // 
            this.TextMessage.Location = new System.Drawing.Point(12, 82);
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.Size = new System.Drawing.Size(269, 275);
            this.TextMessage.TabIndex = 5;
            this.TextMessage.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.decodeToolStripMenuItem});
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
            // decodeToolStripMenuItem
            // 
            this.decodeToolStripMenuItem.Name = "decodeToolStripMenuItem";
            this.decodeToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.decodeToolStripMenuItem.Text = "Decode";
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
            this.BtnClear.Location = new System.Drawing.Point(12, 363);
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
            // EncodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 398);
            this.Controls.Add(this.BtnSelectOutputFile);
            this.Controls.Add(this.LblOutputFile);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.LblFile);
            this.Controls.Add(this.TextMessage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnEncode);
            this.Controls.Add(this.BtnSelectFile);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EncodeForm";
            this.Text = "StegTool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSelectFile;
        private System.Windows.Forms.Button BtnEncode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox TextMessage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label LblFile;
        private System.Windows.Forms.ToolStripMenuItem decodeToolStripMenuItem;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label LblOutputFile;
        private System.Windows.Forms.Button BtnSelectOutputFile;
    }
}
