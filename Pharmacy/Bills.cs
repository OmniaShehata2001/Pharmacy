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

    public partial class Bills : Form
    {
        PharmacyEntity db = new PharmacyEntity();
        public Bills()
        {
            InitializeComponent();
            BillsGrid.DataSource = db.bills.ToList();
        }
    }
}
