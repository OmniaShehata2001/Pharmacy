
namespace Pharmacy
{
    partial class DashBoard
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
            this.Medicine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Medicine
            // 
            this.Medicine.Location = new System.Drawing.Point(473, 122);
            this.Medicine.Name = "Medicine";
            this.Medicine.Size = new System.Drawing.Size(336, 23);
            this.Medicine.TabIndex = 0;
            this.Medicine.Text = "Medicine";
            this.Medicine.UseVisualStyleBackColor = true;
            this.Medicine.Click += new System.EventHandler(this.Medicine_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 603);
            this.Controls.Add(this.Medicine);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Medicine;
    }
}