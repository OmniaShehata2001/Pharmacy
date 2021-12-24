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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void Medicine_Click(object sender, EventArgs e)
        {
            new MedicineForm().Show();
            this.Hide();
        }

        private void AddPharma_Click(object sender, EventArgs e)
        {

        }

        private void addBill_Click(object sender, EventArgs e)
        {

        }

        private void ViewMedicine_Click(object sender, EventArgs e)
        {
            new ViewMedicine().Show();
            this.Hide();
        }

        private void ViewSelles_Click(object sender, EventArgs e)
        {
            new ViewSelles().Show();
            this.Hide();
        }
    }
}
