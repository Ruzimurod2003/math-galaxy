using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MGalaktika
{
    partial class Header_test
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.myLabel = new System.Windows.Forms.Label();
            this.myTextBox = new System.Windows.Forms.TextBox();
            this.myButton = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myLabel
            // 
            this.myLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.myLabel.Location = new System.Drawing.Point(86, 18);
            this.myLabel.Name = "myLabel";
            this.myLabel.Size = new System.Drawing.Size(100, 23);
            this.myLabel.TabIndex = 0;
            this.myLabel.Text = "Salom Dunyo";
            // 
            // myTextBox
            // 
            this.myTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.myTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.myTextBox.Location = new System.Drawing.Point(192, 37);
            this.myTextBox.Name = "myTextBox";
            this.myTextBox.Size = new System.Drawing.Size(148, 23);
            this.myTextBox.TabIndex = 1;
            // 
            // myButton
            // 
            this.myButton.Location = new System.Drawing.Point(0, 0);
            this.myButton.Name = "myButton";
            this.myButton.Size = new System.Drawing.Size(75, 23);
            this.myButton.TabIndex = 0;
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OK.ForeColor = System.Drawing.SystemColors.Control;
            this.OK.Location = new System.Drawing.Point(86, 80);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(41, 32);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Header
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.OK);
            this.Controls.Add(this.myLabel);
            this.Controls.Add(this.myTextBox);
            this.Name = "Header";
            this.Size = new System.Drawing.Size(375, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void My_Click(object sender,EventArgs e)
        {
            //buruq
        }

        private Label myLabel;
        private TextBox myTextBox;
        private Button myButton;
        private Button OK;
    }

        #endregion

}

