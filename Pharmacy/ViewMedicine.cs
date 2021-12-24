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
    public partial class ViewMedicine : Form
    {
        PharmacyEntity db = new PharmacyEntity();
        public ViewMedicine()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.Medicines.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



       

        private void TextChange(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Medicines.Where(x => x.Name.Contains(SearchBox.Text.Trim())).ToList();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            new MedicineForm().Show();
            this.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new DashBoard().Show();
            this.Hide();
        }
    }
}
