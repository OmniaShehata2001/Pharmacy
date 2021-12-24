using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    
    public partial class AddPharmacistForm : Form
    {
        PharmacyEntity db = new PharmacyEntity();
        public AddPharmacistForm()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            pharmacist pharmacist = new pharmacist
            {
                Name = Name.Text.Trim(),
                Email = Email.Text.Trim(),
                ADDRESS = Address.Text.Trim(),
                AGE = Convert.ToInt32(Age.Value),

            };
            db.pharmacists.Add(pharmacist);
            db.SaveChanges();
            Name.Text = "";
            Email.Text = "";
            Address.Text = "";
            Age.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new DashBoard().Show();
            this.Hide();
        }
    }
}
