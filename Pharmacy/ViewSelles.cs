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
    public partial class ViewSelles : Form
    {
        PharmacyEntity db = new PharmacyEntity();
        public ViewSelles()
        {
            InitializeComponent();
        }

        private void Search(object sender, EventArgs e)
        {
            DateGrid.DataSource = db.bills.Where(x => x.billDate.Value == DateSearch.Value).ToList();
        }
    }
}
