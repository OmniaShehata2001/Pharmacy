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
    public partial class Login : Form
    {
        PharmacyEntity db = new PharmacyEntity();
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var email = mail.Text.Trim();
            var pass = Password.Text.Trim();
            if (db.accounts.Any(xx => xx.Email.Equals(email) &&xx.password.Equals(pass)))
            {
                new DashBoard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("your Username or Password is inCorrect");
            }
        }

       
    }
}
