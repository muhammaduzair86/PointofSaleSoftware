using DevExpress.XtraBars;
using PointofSaleSoftware.Screens.ProductsF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointofSaleSoftware
{
    public partial class POS : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public POS()
        {
            InitializeComponent();
        }

        private void ribbonPageGroup1_CaptionButtonClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e)
        {
            this.Hide();
            Screens.ProductsF.Customer cf = new Customer();
            cf.Show();
        }

        private void ribbonPageGroup2_CaptionButtonClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e)
        {

            this.Hide();
            Screens.ProductsF.Suppliers sup = new Suppliers();
            sup.Show();
        }

        private void ribbonPageGroup3_CaptionButtonClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e)
        {
            this.Hide();
            //Screens.ProductsF.Products prd = new Products();
            //prd.Show();
        }

        private void rpg_Purchases_CaptionButtonClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e)
        {
            this.Hide();
            Screens.ProductsF.frmPurchase purchase = new frmPurchase();
            purchase.Show();
        }

        private void POS_Load(object sender, EventArgs e)
        {
            doMaximize();
        }

        private void doMaximize()
        {
            this.WindowState = FormWindowState.Maximized;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
        }

       
    }
}