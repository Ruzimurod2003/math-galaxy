﻿using System;
namespace MGalaktika.Components
{
    partial class Account
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
        private void InitializeComponent()
        {
            this.LoginUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordUser = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginUser
            // 
            this.LoginUser.Location = new System.Drawing.Point(4, 20);
            this.LoginUser.Name = "LoginUser";
            this.LoginUser.Size = new System.Drawing.Size(159, 23);
            this.LoginUser.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parol";
            // 
            // PasswordUser
            // 
            this.PasswordUser.Location = new System.Drawing.Point(4, 64);
            this.PasswordUser.Name = "PasswordUser";
            this.PasswordUser.Size = new System.Drawing.Size(159, 23);
            this.PasswordUser.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kirish";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginUser);
            this.Name = "Account";
            this.Size = new System.Drawing.Size(167, 123);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordUser;
        private System.Windows.Forms.Button button1;
    }
}
