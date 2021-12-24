
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
            this.Quantity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Qunatity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).BeginInit();
            this.SuspendLayout();
            // 
            // MedicineName
            // 
            this.MedicineName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MedicineName.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicineName.Location = new System.Drawing.Point(571, 123);
            this.MedicineName.Multiline = true;
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.Size = new System.Drawing.Size(358, 39);
            this.MedicineName.TabIndex = 0;
            this.MedicineName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MedicineName.UseWaitCursor = true;
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
            this.button1.Location = new System.Drawing.Point(641, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Medicine";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Qunatity
            // 
            this.Qunatity.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Qunatity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qunatity.Location = new System.Drawing.Point(571, 205);
            this.Qunatity.Name = "Qunatity";
            this.Qunatity.Size = new System.Drawing.Size(358, 36);
            this.Qunatity.TabIndex = 7;
            // 
            // Price
            // 
            this.Price.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(571, 261);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(358, 36);
            this.Price.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Medicine Name";
            // 
            // Quantity
            // 
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(346, 205);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(164, 36);
            this.Quantity.TabIndex = 10;
            this.Quantity.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 36);
            this.label2.TabIndex = 11;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(341, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 36);
            this.label3.TabIndex = 12;
            this.label3.Text = "MGS Date";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(341, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 36);
            this.label4.TabIndex = 13;
            this.label4.Text = "EXP Date";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(550, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(393, 63);
            this.label5.TabIndex = 14;
            this.label5.Text = "Add Medicine";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(44, 31);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(161, 34);
            this.Back.TabIndex = 15;
            this.Back.Text = "Back to Dashboard";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // MedicineForm
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1488, 765);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Quantity);
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
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Back;
    }
}