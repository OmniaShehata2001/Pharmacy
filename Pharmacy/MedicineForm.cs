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
    public partial class MedicineForm : Form
    {
        PharmacyEntity db = new PharmacyEntity();
        public MedicineForm()
        {
            InitializeComponent();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine
            {
                MGS = MSG.Value,
                expire =  EXP.Value,
                Name =MedicineName.Text,
                Price = Price.Value,
                Quantity = Convert.ToInt32(Qunatity.Value),
            };
            db.Medicines.Add(medicine);
            db.SaveChanges();
            MSG.Value = DateTime.Now;
            EXP.Value = DateTime.Now;
            Price.Value = 0;
            Qunatity.Value = 0;
            MedicineName.Text = " ";
        }

        
    }
}
