
using System.Drawing;

namespace MGalaktika
{
    partial class Right
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
            this.account1 = new MGalaktika.Components.Account();
            this.SuspendLayout();
            // 
            // account1
            // 
            this.account1.AutoSize = true;
            this.account1.BackColor = System.Drawing.SystemColors.Control;
            this.account1.Location = new System.Drawing.Point(8, 6);
            this.account1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.account1.Name = "account1";
            this.account1.Size = new System.Drawing.Size(351, 238);
            this.account1.TabIndex = 0;
            // 
            // Right
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.account1);
            this.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Right";
            this.Size = new System.Drawing.Size(365, 569);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.Account account1;
    }
}
