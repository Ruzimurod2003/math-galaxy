
using System.Drawing;

namespace MGalaktika.Components
{
    partial class Layout
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
            this.label1 = new System.Windows.Forms.Label();
            this.AcountName = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matematika galaktikasiga hush kelibsiz";
            // 
            // AcountName
            // 
            this.AcountName.AutoSize = true;
            this.AcountName.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.AcountName.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.AcountName.Location = new System.Drawing.Point(494, 14);
            this.AcountName.Name = "AcountName";
            this.AcountName.Size = new System.Drawing.Size(140, 28);
            this.AcountName.TabIndex = 1;
            this.AcountName.TabStop = true;
            this.AcountName.Text = "Ro\'zimurod";
            this.AcountName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AcountName_LinkClicked);
            // 
            // Layout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.AcountName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Layout";
            this.Size = new System.Drawing.Size(648, 51);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel AcountName;
    }
}
