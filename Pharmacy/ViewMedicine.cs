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
            if (SearchBox.Text.Equals(""))
            {
                dataGridView1.DataSource = db.Medicines.ToList();
            }
            else
            {
                dataGridView1.DataSource = db.Medicines.Where(x => x.Name.Contains(SearchBox.Text.Trim())).ToList();
            }
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

        private void Buy_Click(object sender, EventArgs e)
        {
            if (SearchBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("No data Entered");
            }
            var ids =  db.Medicines.Where(x => x.Name.Contains(SearchBox.Text.Trim())).ToList().Select(x=>x.Id);
            var medicines = db.Medicines.Where(x => ids.Contains(x.Id)).ToList();
            bool cont  = true;
            medicines.ForEach(x => 
            {
                if (x.Quantity <= 0)
                {
                    MessageBox.Show("you Choose Items We Don't have.");
                    cont = false;
                }
            });
            if (cont)
            {
                medicines.ForEach(x =>
                {
                    if (x.Quantity > 0)
                    {
                        x.Quantity--;
                    }

                });
                db.SaveChanges();
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            if (SearchBox.Text.Equals(""))
            {
                dataGridView1.DataSource = db.Medicines.ToList();
            }
            else
            {
                dataGridView1.DataSource = db.Medicines.Where(x => x.Name.Contains(SearchBox.Text.Trim())).ToList();
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (SearchBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("No data Entered");
            }
            var ids = db.Medicines.Where(x => x.Name.Contains(SearchBox.Text.Trim())).ToList().Select(x => x.Id);
            var medicines = db.Medicines.Where(x => ids.Contains(x.Id)).ToList();


            medicines.ForEach(x =>
            {
                x.Quantity++;

            });
            db.SaveChanges();
        }
    }
}
