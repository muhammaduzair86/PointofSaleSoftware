using PointofSaleSoftware.Screens.ProductsF;
using System;
using System.Windows.Forms;
namespace PointofSaleSoftware.Screens
{
    public partial class DashboardForm : MetroFramework.Forms.MetroForm
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            ProductsF.Customer cf = new Customer();
            cf.Show();
        }

        private void btn_OrdersReceived_Click(object sender, EventArgs e)
        {
            ProductsF.Suppliers sup = new Suppliers();
            sup.Show();
        }

        private void btn_Purchases_Click(object sender, EventArgs e)
        {
            ProductsF.frmPurchase pur = new frmPurchase();
            pur.Show();
        }
    }
}
