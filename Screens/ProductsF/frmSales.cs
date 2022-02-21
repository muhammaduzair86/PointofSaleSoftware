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
    public partial class btn_Save_Sales : MetroFramework.Forms.MetroForm
    {
        public btn_Save_Sales()
        {
            InitializeComponent();
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            // Populating All Combo Boxes on the Form
            BindFields();
            // Doing Calculations on the Form
            calcTotals();

            // Focusing the cursor in Invoice Number
            txtInvoiceNumber.Focus();

            //Loading Values in Product Combo Box
            populateProducts();
        }

        void populateProducts()
        {
            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM PRODUCTS", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                StockID.ValueMember = "ProductID";
                StockID.DisplayMember = "Name";
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Select-";
                dtbl.Rows.InsertAt(topItem, 0);
                StockID.DataSource = dtbl;
                
            }
        }

        void populateDataGridView()
        {
            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM SalesOrderDetails", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgv_SaleDet.DataSource = dtbl;
                

            }

        }
        private void BindFields()
        {
            Data.Bind(CustomerName, "SELECT Name, CustomerID from Customers", "Name", "CustomerID");
            //Data.Bind(cmb_Item, "SELECT Name, ProductID from Products", "Name", "ProductID");
        }
        private void calcTotals() 
        {
            double namount = 0, balance = 0;
            if (!string.IsNullOrEmpty(txtGrandTotal.Text) & !string.IsNullOrEmpty(txtDiscount.Text))
            {
                namount = Convert.ToDouble(txtGrandTotal.Text) - Convert.ToUInt16(txtDiscount.Text);
                balance = Convert.ToDouble(namount) - Convert.ToDouble(txtCash.Text);
            }
            else
            {
                int myVal = 0;
                txtGrandTotal.Text = Convert.ToString(myVal);
                txtDiscount.Text = Convert.ToString(myVal);
                txtNet.Text = Convert.ToString(myVal);
                txtCash.Text = Convert.ToString(myVal);
                txtBalance.Text = Convert.ToString(myVal);

            }
            
                    }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (SaleValid())
            { 
            
            }
            }

        private bool SaleValid()
        {
            if (String.IsNullOrEmpty(txtInvoiceNumber.Text))
            {
                MessageBox.Show("Please provide Invoice Number", "Validation Error");
                return false;
            }

            if (String.IsNullOrEmpty(InvoiceDate.Text))
            {
                MessageBox.Show("Please provide Invoice Date", "Validation Error");
                return false;
            }
            if (String.IsNullOrEmpty(CustomerName.Text))
            {
                MessageBox.Show("Please provide Customer Name", "Validation Error");
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveRecord();
        }
        void SaveRecord()
        {
            string query = "";
                query = @"insert into SalesOrders (InvoiceDate, CustomerID, GrandTotal,Discount,Net,Cash,Balance)
                    values('" + InvoiceDate.Value.ToString("yyyy-MM-dd") + @"'
                    ,'" + CustomerName.SelectedValue + @"'
                    ,'" + txtGrandTotal.Text + @"'
                    ,'" + txtDiscount.Text + @"'
                    ,'" + txtNet.Text + @"'
                    ,'" + txtCash.Text + @"'
                    ,'" + txtBalance.Text + @"'
                    ); select scope_identity()";
                int pid = Data.RunActionQuery(query);
                //if (pid > 0)
                //{
                DataTable dt = (DataTable)dgv_SaleDet.DataSource;
                foreach (DataRow dataRow in dt.Rows)
                {
                    if (dataRow.RowState != DataRowState.Deleted)
                    {
                        query = @"insert into SalesOrderDetails(InvoiceNumber, StockID, Price, Quantity, TotalPrice)
                            values('" + pid + @"'
                            , '" + dataRow["InvoiceNumber"] + @"'
                            , '" + dataRow["StockID"] + @"'
                            , '" + dataRow["Price"] + @"'
                            , '" + dataRow["Quantity"] + @"'
                            , '" + dataRow["TotalPrice"] + @"'
                            )";
                        Data.RunActionQuery(query);
                    }
                }
            }
               
    }
}
