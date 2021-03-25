﻿namespace Billing_System
{
    partial class Reset_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reset_Password));
            this.resetpswdpic = new System.Windows.Forms.PictureBox();
            this.resetpagelbl = new System.Windows.Forms.Label();
            this.pswdresetlbl = new System.Windows.Forms.Label();
            this.pswdverifylbl = new System.Windows.Forms.Label();
            this.pswdverifytxt = new System.Windows.Forms.TextBox();
            this.pswdresettxt = new System.Windows.Forms.TextBox();
            this.resetbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resetpswdpic)).BeginInit();
            this.SuspendLayout();
            // 
            // resetpswdpic
            // 
            this.resetpswdpic.Image = ((System.Drawing.Image)(resources.GetObject("resetpswdpic.Image")));
            this.resetpswdpic.Location = new System.Drawing.Point(100, 57);
            this.resetpswdpic.Name = "resetpswdpic";
            this.resetpswdpic.Size = new System.Drawing.Size(100, 86);
            this.resetpswdpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resetpswdpic.TabIndex = 0;
            this.resetpswdpic.TabStop = false;
            this.resetpswdpic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // resetpagelbl
            // 
            this.resetpagelbl.AutoSize = true;
            this.resetpagelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetpagelbl.Location = new System.Drawing.Point(107, 21);
            this.resetpagelbl.Name = "resetpagelbl";
            this.resetpagelbl.Size = new System.Drawing.Size(93, 20);
            this.resetpagelbl.TabIndex = 1;
            this.resetpagelbl.Text = "Reset Page";
            this.resetpagelbl.Click += new System.EventHandler(this.resetpagelbl_Click);
            // 
            // pswdresetlbl
            // 
            this.pswdresetlbl.AutoSize = true;
            this.pswdresetlbl.Location = new System.Drawing.Point(46, 152);
            this.pswdresetlbl.Name = "pswdresetlbl";
            this.pswdresetlbl.Size = new System.Drawing.Size(84, 13);
            this.pswdresetlbl.TabIndex = 2;
            this.pswdresetlbl.Text = "Password Reset";
            // 
            // pswdverifylbl
            // 
            this.pswdverifylbl.AutoSize = true;
            this.pswdverifylbl.Location = new System.Drawing.Point(46, 194);
            this.pswdverifylbl.Name = "pswdverifylbl";
            this.pswdverifylbl.Size = new System.Drawing.Size(82, 13);
            this.pswdverifylbl.TabIndex = 2;
            this.pswdverifylbl.Text = "Password Verify";
            // 
            // pswdverifytxt
            // 
            this.pswdverifytxt.Location = new System.Drawing.Point(173, 187);
            this.pswdverifytxt.Multiline = true;
            this.pswdverifytxt.Name = "pswdverifytxt";
            this.pswdverifytxt.PasswordChar = '*';
            this.pswdverifytxt.Size = new System.Drawing.Size(100, 20);
            this.pswdverifytxt.TabIndex = 3;
            // 
            // pswdresettxt
            // 
            this.pswdresettxt.Location = new System.Drawing.Point(173, 149);
            this.pswdresettxt.Multiline = true;
            this.pswdresettxt.Name = "pswdresettxt";
            this.pswdresettxt.PasswordChar = '*';
            this.pswdresettxt.Size = new System.Drawing.Size(100, 20);
            this.pswdresettxt.TabIndex = 3;
            this.pswdresettxt.TextChanged += new System.EventHandler(this.pswdresettxt_TextChanged);
            // 
            // resetbtn
            // 
            this.resetbtn.Location = new System.Drawing.Point(125, 235);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(75, 23);
            this.resetbtn.TabIndex = 4;
            this.resetbtn.Text = "Reset";
            this.resetbtn.UseVisualStyleBackColor = true;
            // 
            // Reset_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(364, 345);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.pswdresettxt);
            this.Controls.Add(this.pswdverifytxt);
            this.Controls.Add(this.pswdverifylbl);
            this.Controls.Add(this.pswdresetlbl);
            this.Controls.Add(this.resetpagelbl);
            this.Controls.Add(this.resetpswdpic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Reset_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset_Password";
            ((System.ComponentModel.ISupportInitialize)(this.resetpswdpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox resetpswdpic;
        private System.Windows.Forms.Label resetpagelbl;
        private System.Windows.Forms.Label pswdresetlbl;
        private System.Windows.Forms.Label pswdverifylbl;
        private System.Windows.Forms.TextBox pswdverifytxt;
        private System.Windows.Forms.TextBox pswdresettxt;
        private System.Windows.Forms.Button resetbtn;
    }
}