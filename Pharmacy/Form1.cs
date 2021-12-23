using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class Form1 : Form
    {
        PharmacyEntity db = new PharmacyEntity();
        public Form1()
        {
            InitializeComponent();
            dataGridView.DataSource = db.pharmacists.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //var data = db.pharmacists.ToList();
            pharmacist phar1 = new pharmacist
            {
                Name = text1.Text.Trim(),
                City = City.Text.Trim()
            };
            db.pharmacists.Add(phar1);
            db.SaveChanges();
            text1.Text = "";
            City.Text = "";
            dataGridView.DataSource = db.pharmacists.ToList();
        }

        
    }
}
