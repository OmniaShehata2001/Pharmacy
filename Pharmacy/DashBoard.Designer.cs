
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddPharma = new System.Windows.Forms.Button();
            this.ViewMedicine = new System.Windows.Forms.Button();
            this.ViewSelles = new System.Windows.Forms.Button();
            this.addBill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Medicine
            // 
            this.Medicine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Medicine.Location = new System.Drawing.Point(423, 114);
            this.Medicine.Name = "Medicine";
            this.Medicine.Size = new System.Drawing.Size(255, 37);
            this.Medicine.TabIndex = 0;
            this.Medicine.Text = "Add Medicine";
            this.Medicine.UseVisualStyleBackColor = false;
            this.Medicine.Click += new System.EventHandler(this.Medicine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "DashBoard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddPharma
            // 
            this.AddPharma.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddPharma.Location = new System.Drawing.Point(423, 191);
            this.AddPharma.Name = "AddPharma";
            this.AddPharma.Size = new System.Drawing.Size(255, 39);
            this.AddPharma.TabIndex = 2;
            this.AddPharma.Text = "Add Pharmcist";
            this.AddPharma.UseVisualStyleBackColor = false;
            this.AddPharma.Click += new System.EventHandler(this.AddPharma_Click);
            // 
            // ViewMedicine
            // 
            this.ViewMedicine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ViewMedicine.Location = new System.Drawing.Point(423, 310);
            this.ViewMedicine.Name = "ViewMedicine";
            this.ViewMedicine.Size = new System.Drawing.Size(255, 39);
            this.ViewMedicine.TabIndex = 3;
            this.ViewMedicine.Text = "View Medicine";
            this.ViewMedicine.UseVisualStyleBackColor = false;
            this.ViewMedicine.Click += new System.EventHandler(this.ViewMedicine_Click);
            // 
            // ViewSelles
            // 
            this.ViewSelles.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ViewSelles.Location = new System.Drawing.Point(423, 380);
            this.ViewSelles.Name = "ViewSelles";
            this.ViewSelles.Size = new System.Drawing.Size(255, 39);
            this.ViewSelles.TabIndex = 4;
            this.ViewSelles.Text = "View Selles";
            this.ViewSelles.UseVisualStyleBackColor = false;
            this.ViewSelles.Click += new System.EventHandler(this.ViewSelles_Click);
            // 
            // addBill
            // 
            this.addBill.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addBill.Location = new System.Drawing.Point(423, 249);
            this.addBill.Name = "addBill";
            this.addBill.Size = new System.Drawing.Size(255, 39);
            this.addBill.TabIndex = 5;
            this.addBill.Text = "Add Bill";
            this.addBill.UseVisualStyleBackColor = false;
            this.addBill.Click += new System.EventHandler(this.addBill_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 603);
            this.Controls.Add(this.addBill);
            this.Controls.Add(this.ViewSelles);
            this.Controls.Add(this.ViewMedicine);
            this.Controls.Add(this.AddPharma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Medicine);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Medicine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddPharma;
        private System.Windows.Forms.Button ViewMedicine;
        private System.Windows.Forms.Button ViewSelles;
        private System.Windows.Forms.Button addBill;
    }
}