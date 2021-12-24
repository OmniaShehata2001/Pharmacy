
namespace Pharmacy
{
    partial class MedicineForm
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
            this.MedicineName = new System.Windows.Forms.TextBox();
            this.MSG = new System.Windows.Forms.DateTimePicker();
            this.EXP = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.Qunatity = new System.Windows.Forms.NumericUpDown();
            this.Price = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Qunatity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).BeginInit();
            this.SuspendLayout();
            // 
            // MedicineName
            // 
            this.MedicineName.Location = new System.Drawing.Point(571, 107);
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.Size = new System.Drawing.Size(358, 22);
            this.MedicineName.TabIndex = 0;
            // 
            // MSG
            // 
            this.MSG.Location = new System.Drawing.Point(571, 326);
            this.MSG.Name = "MSG";
            this.MSG.Size = new System.Drawing.Size(358, 22);
            this.MSG.TabIndex = 4;
            // 
            // EXP
            // 
            this.EXP.Location = new System.Drawing.Point(571, 390);
            this.EXP.Name = "EXP";
            this.EXP.Size = new System.Drawing.Size(358, 22);
            this.EXP.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(358, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Medicine";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Qunatity
            // 
            this.Qunatity.Location = new System.Drawing.Point(571, 205);
            this.Qunatity.Name = "Qunatity";
            this.Qunatity.Size = new System.Drawing.Size(358, 22);
            this.Qunatity.TabIndex = 7;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(571, 261);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(358, 22);
            this.Price.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(568, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Medicine Form ";
            // 
            // MedicineForm
            // 
            this.ClientSize = new System.Drawing.Size(1381, 643);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Qunatity);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EXP);
            this.Controls.Add(this.MSG);
            this.Controls.Add(this.MedicineName);
            this.Name = "MedicineForm";
            ((System.ComponentModel.ISupportInitialize)(this.Qunatity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox MedicineName;
        private System.Windows.Forms.DateTimePicker MSG;
        private System.Windows.Forms.DateTimePicker EXP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown Qunatity;
        private System.Windows.Forms.NumericUpDown Price;
        private System.Windows.Forms.Label label1;
    }
}