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

            if (cbo_ProductName.Text != "")
            {
                DataTable dt = (DataTable)dgv_SalesDet.DataSource;
                DataRow dr = dt.NewRow();
                dr["DetailID"] = DBNull.Value;
                dr["InvoiceNumber"] = DBNull.Value;
                if (!string.IsNullOrEmpty((string)txtInvoiceNumber.Text))
                dr["ProductID"] = Convert.ToInt32(cbo_ProductName.SelectedValue);
                dr["Quantity"] = 1;
                dr["SaleRate"] = Convert.ToDecimal(txtSaleQty.Text);
                dr["TotalAmount"] = 1 * Convert.ToDecimal(txtSaleQty.Text);
                dt.Rows.Add(dr);
                dgv_SalesDet.DataSource = dt;
            }
            else 
            {
                _ = MessageBox.Show("Nothing Selected from Product List", "Form Validation Error");
            }


        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            //returnProductData();
            generateGrid();
        }

        
        private void returnProductData()
        {
            
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
           
        }

      

        private void txtSaleQty_TextChanged(object sender, EventArgs e)
        {
           /* if (txtSaleQty.Text != "")
            {
                double usq, osr, utp;                
                usq = int.Parse(txtSaleQty.Text);
                osr = double.Parse(txtSaleRate.Text);
                utp = usq * osr;
                txt_TotalAmount.Text = Convert.ToString(utp);
                this.CalculateTotals();
            }*/
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
            returnProductData();
        }
    }
        }
