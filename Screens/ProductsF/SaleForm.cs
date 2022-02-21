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
using System.Data.SqlClient;


namespace PointofSaleSoftware.Screens.ProductsF
{
    public partial class SaleForm : MetroFramework.Forms.MetroForm
    {
        public SaleForm()
        {
            InitializeComponent();
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            CustomProcess();

        }
        private void CustomProcess()
        {
            dgv_SalesDet.Height = Height - 300;
            dgv_SalesDet.Width = Width - 200;

            txtInvoiceNumber.Visible = false;
            cbo_Customer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbo_Customer.AutoCompleteSource = AutoCompleteSource.ListItems;
            Data.Bind(cbo_Customer, "Select Name as CName, CustomerID from Customers", "CName", "CustomerID");


            cbo_ProductName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbo_ProductName.AutoCompleteSource = AutoCompleteSource.ListItems;
            Data.Bind(cbo_ProductName, "Select Name as PName, ProductID from Products ", "PName", "ProductID");

        }
        private void generateGrid()
        {
            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.getSalePrice(@ProdID);", con))
                {
                    cmd.Parameters.AddWithValue("@ProdID", cbo_ProductName.SelectedValue);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    //DataTable dt = (DataTable) dgv_SalesDet.DataSource;
                    DataRow dr = dt.NewRow();
                    da.Fill(dt);
                    dgv_SalesDet.DataSource = dt;
                    dt.Rows.Add(dr);
                    /*dr["DetailID"] = DBNull.Value;
                    dr["InvoiceNumber"] = DBNull.Value;
                    //if (!string.IsNullOrEmpty((string)cbo_ProductName.SelectedValue))
                    dr["ProductID"] = Convert.ToInt32(cbo_ProductName.SelectedValue);
                    dr["Quantity"] = 1;
                    //dr["SaleRate"] = dt.Columns[4];
                    //dr["TotalAmount"] = dt.Columns[6];*/



                }
            }
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            generateGrid();
        }


        /*private void CalculateTotals()
        {
            double total = 0;
            DataTable dt = (DataTable)dgv_SalesDet.DataSource;
            foreach (DataRow dataRow in dt.Rows)
            {
                if (dataRow.RowState != DataRowState.Deleted)
                    total += Convert.ToDouble(dataRow["TotalPrice"]);
            }
            txtGrandTotal.Text = total.ToString("n2");
        }
        */



    }
}
