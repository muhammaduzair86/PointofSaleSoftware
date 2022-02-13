using PointofSaleSoftware.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointofSaleSoftware.Screens.ProductsF
{
    public partial class frmSearchPurchase : Form
    {
        public frmSearchPurchase()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void LoadData()
        {
            string query = "select * from Purchase";
            dataGridView1.DataSource = Data.RunSelectQuery(query);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPurchase f = new frmPurchase();
            f.ShowDialog();
            this.LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int Id= Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                frmPurchase f = new frmPurchase();
                f.EditId = Id;
                f.ShowDialog();
                this.LoadData();
            }

        }
    }
}
