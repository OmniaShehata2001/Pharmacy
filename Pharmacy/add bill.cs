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
    public partial class add_bill : Form
    {
        PharmacyEntity db = new PharmacyEntity();
        public add_bill()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            new DashBoard().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bill bill = new bill
            {
                ProductName = Product.Text,
                billDate=Date.Value,
                balance=Price.Value,
                Quantity = Convert.ToInt32(Qunatity.Value),
                Discount= Convert.ToInt32(Discount.Value)
            };
            db.bills.Add(bill);
            db.SaveChanges();
            Product.Text = " ";
            Price.Value = 0;
            Qunatity.Value = 0;
            Discount.Value = 0;
            Date.Value = DateTime.Now;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Quantity_Click(object sender, EventArgs e)
        {

        }
    }
}
