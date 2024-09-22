using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1_AdonetCustomer
{
    public partial class FrmMap : Form
    {
        public FrmMap()
        {
            InitializeComponent();
        }

        private void BtnOpenCityForm_Click(object sender, EventArgs e)
        {
            FrmCity frci = new FrmCity();
            frci.Show();
        }

        private void BtnOpenCustomerForm_Click(object sender, EventArgs e)
        {
            FrmCustomer frmcu = new FrmCustomer();
            frmcu.Show();
        }

        private void BtnExis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
