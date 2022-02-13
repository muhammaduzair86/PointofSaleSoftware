using PointofSaleSoftware.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointofSaleSoftware.Screens.ProductsF
{
    public partial class Products : MetroFramework.Forms.MetroForm
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
          
            dgv_Products.Height = Height - 300;
            combo_loadsuppliers();
        }
        private void combo_loadsuppliers()
        {
            DataRow dr;
            SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString());
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM SUPPLIERS", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select Supplier--" };
            dt.Rows.InsertAt(dr, 0);
            cbo_Supplier.ValueMember = "supp_id";
            cbo_Supplier.DisplayMember = "supp_name";
            cbo_Supplier.DataSource = dt;
            con.Close();

        }
            }
        }
    
