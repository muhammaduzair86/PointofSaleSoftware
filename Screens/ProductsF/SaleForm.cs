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
    public partial class frm_SaleForm : MetroFramework.Forms.MetroForm
    {
        public frm_SaleForm()
        {
            InitializeComponent();
        }


        private void SaleForm_Load(object sender, EventArgs e)
        {
            dginitialize();
            CustomProcess();
            ClearSaleForm();
            cbo_ProductName.Focus();

        }
        private void dginitialize()
        {
            //initialize datagridview datasource
            string query = "select * from SalesOrderDetails where DetailID=-1";
            DataTable dt = Data.RunSelectQuery(query);
            dgv_SalesDet.DataSource = dt;
            dgv_SalesDet.Columns[0].Visible = false;
            dgv_SalesDet.Columns[1].Visible = false;
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
            Data.Bind(cbo_ProductName, "Select Name, ProductID from Products ", "Name", "ProductID");

        }
        private void generateGrid()
        {

            if (cbo_ProductName.Text != "")
            {
                DataTable dt = (DataTable)dgv_SalesDet.DataSource;
                DataRow dr = dt.NewRow();
                dr["DetailID"] = DBNull.Value;
                dr["InvoiceNumber"] = DBNull.Value;
                dr["ProductID"] = Convert.ToInt32(cbo_ProductName.SelectedValue);
                dr["ProductName"] = ((DataRowView)cbo_ProductName.SelectedItem)["Name"].ToString();
                decimal qty, rate, price;
                qty = Convert.ToDecimal(txtSaleQty.Text);
                rate = Convert.ToDecimal(txtSaleRate.Text);
                price = qty * rate;
                dr["Quantity"] = qty;
                dr["Price"] = rate;
                dr["TotalPrice"] = price;
                dt.Rows.Add(dr);
                dgv_SalesDet.DataSource = dt;
                ClearSaleForm();
                cbo_ProductName.Focus();
            }



        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            //returnProductData();
            generateGrid();
            CalculateTotals();
            //ClearSaleForm();
        }


        private void returnProductData()
        {
            string query = "SELECT * FROM dbo.getSalePrice('" + cbo_ProductName.SelectedValue.ToString() + "')";
            DataTable dt = Data.RunSelectQuery(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                txtSaleQty.Text = dt.Rows[0]["Quantity"].ToString();
                txtSaleRate.Text = dt.Rows[0]["SaleRate"].ToString();
            }
            /*
            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.getSalePrice(@ProdID);", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@ProdID", cbo_ProductName.SelectedValue);
                    SqlDataReader da = cmd.ExecuteReader();
                    while (da.Read())
                    {
                        txtSaleQty.Text = da.GetValue(5).ToString();
                        txtSaleRate.Text = da.GetValue(4).ToString();
                        double sq, sr, tp;
                        sq = int.Parse(txtSaleQty.Text);
                        sr = double.Parse(txtSaleRate.Text);
                        tp = sq * sr;
                        txt_TotalAmount.Text = Convert.ToString(tp);

                    }
                    con.Close();
                }
            }
            */
        }



        private void txtSaleQty_TextChanged(object sender, EventArgs e)
        {
            if (txtSaleQty.Text != "")
            {
                decimal ta = Data.SaleValueCalc(txtSaleQty.Text, txtSaleRate.Text);
                txt_TotalAmount.Text = Convert.ToString(ta);
                CalculateTotals();
            }
            else
            {
                MessageBox.Show("Please Enter Sale Qty", "Sale Qty Error");
                txtSaleQty.Focus();
            }
        }



        private void CalculateTotals()
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

        private void btn_Temp_Click(object sender, EventArgs e)
        {

        }

        private void cbo_ProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_ProductName.SelectedIndex >= 0)
            {
                returnProductData();
                txtSaleQty.Focus();
            }
        }
        private void ClearSaleForm()
        {
            cbo_ProductName.Text = "";
            txtSaleQty.Text = "";
            txtSaleRate.Text = "";
            txt_TotalAmount.Text = "";
            txtGrandTotal.Text = "";
            txtDiscount.Text = "";
            txtCash.Text = "";
            txtNet.Text = "";
            txtBalance.Text = "";
            
            cbo_ProductName.Focus();
        }

        private void frm_SaleForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.D)

            {
                txtDiscount.Focus();
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscount.Text != "")
            {
                decimal myNet;
                myNet = Convert.ToDecimal(txtGrandTotal.Text) - Convert.ToDecimal(txtDiscount.Text);
                txtNet.Text = myNet.ToString();
            }
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            if (txtCash.Text != "")
            {
                decimal myCash, myBalance;
                myCash = Convert.ToDecimal(txtCash.Text);
                myBalance = Convert.ToDecimal(txtNet.Text) - myCash;
                txtBalance.Text = myBalance.ToString();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txtGrandTotal.Text != "")
            {
                InsertSalesData();
            }
            else
            {
                MessageBox.Show("No Data found to Insert", "Please enter Sale Data", MessageBoxButtons.OK);
                cbo_ProductName.Focus();
            }
        }
        private void InsertSalesData()
        {
            string query = @"insert into SalesOrders (InvoiceDate, CustomerID, GrandTotal,Discount,Net,Cash,Balance)
                    values('" + dt_InvoiceDate.Value.ToString("yyyy-MM-dd") + @"'
                    ,'" + cbo_ProductName.SelectedValue + @"'
                    ,'" + ((string.IsNullOrEmpty(txtGrandTotal.Text)) ? 0 : Convert.ToDecimal(txtGrandTotal.Text)) + @"'
		            ,'" + ((string.IsNullOrEmpty(txtDiscount.Text))? 0 : Convert.ToDecimal(txtDiscount.Text)) + @"'
		            ,'" + ((string.IsNullOrEmpty(txtNet.Text))? 0 : Convert.ToDecimal(txtNet.Text)) + @"'
		            ,'" + ((string.IsNullOrEmpty(txtCash.Text)) ? 0 : Convert.ToDecimal(txtCash.Text)) + @"'
		            ,'" + ((string.IsNullOrEmpty(txtBalance.Text)) ? 0 : Convert.ToDecimal(txtBalance.Text)) + "'); select scope_identity()";
            int pid = Data.RunActionQuery(query);
            //if (pid > 0)
            //{
            DataTable dt = (DataTable)dgv_SalesDet.DataSource;
            foreach (DataRow dataRow in dt.Rows)
            {
                if (dataRow.RowState != DataRowState.Deleted)
                {
                    query = @"insert into SalesOrderDetails (InvoiceNumber, ProductID, Price, Quantity, TotalPrice,ProductName)
                            values('" + pid + @"'                            
                            , '" + dataRow["ProductID"] + @"'
                            , '" + dataRow["Quantity"] + @"'
                            , '" + dataRow["Price"] + @"'
                            , '" + dataRow["TotalPrice"] + @"'
                            , '" + dataRow["ProductName"] + @"'
                            )";
                    Data.RunActionQuery(query);
                }                
            }
            MessageBox.Show("Saved");
            ClearSaleForm();
            dginitialize();
        }
    }
}


