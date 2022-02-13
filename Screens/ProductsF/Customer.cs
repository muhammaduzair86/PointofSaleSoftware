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
    public partial class Customer : MetroFramework.Forms.MetroForm
    {
       
        public Customer()
        {
           
            InitializeComponent();
        }

      

        private void Customer_Load(object sender, EventArgs e)
        {
           
            myGridView();
            ClearForm();
            btn_Update.Enabled = false;

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
          if (cValid())
            {
                using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
                {
                    using(SqlCommand cmd = new SqlCommand("usp_Customers_InsertCustomer",con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@CName", CustomerName.Text);
                            cmd.Parameters.AddWithValue("@CAddress", CustomerAddress.Text);
                            cmd.Parameters.AddWithValue("@CContact", CustomerCell.Text);
                        con.Open();
                        int id = Convert.ToInt32(cmd.ExecuteScalar());
                        MessageBox.Show("Customer is saved Successfully in the System","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //DataTable dt = new DataTable();
                        //SqlCommand myCmd = new SqlCommand("usp_CustomersInfo", con);
                        //myCmd.CommandType = CommandType.StoredProcedure;
                        //SqlDataAdapter da = new SqlDataAdapter(myCmd);
                        //da.Fill(dt);
                        //dataGridView1.DataSource = dt;
                        myGridView();
                        //dataGridView1.DataBindings();
                        ClearForm();

                    }
                }
            }
        }
        private void myGridView()
        {
            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_Customers_InsertCustomer", con))
                {
                    DataTable dt = new DataTable();
                    SqlCommand myCmd = new SqlCommand("usp_CustomersInfo", con);
                    myCmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(myCmd);
                    da.Fill(dt);
                    DataGridView1.DataSource = dt;
                    DataGridView1.Columns[0].Width = 25;
                    DataGridView1.Columns[1].Width = 200;
                    DataGridView1.Columns[2].Width = 100;
                    DataGridView1.Columns[3].Width = 200;

                }
            }
        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
        }
        private bool cValid()
        {
            if (CustomerName.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Sorry! Customer Name not found", "Form Validation Error");
                return false;                
            }
            if (CustomerAddress.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Sorry! Customer Address not found", "Form Validation Error");
                return false;
            }
            if (CustomerCell.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Sorry! Customer Cell Number not found", "Form Validation Error");
                return false;
            }
            return true;
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
        private void ClearForm()
        {
            metroTextBox1.Text = "";
            CustomerName.Text = "";
            CustomerAddress.Text = "";
            CustomerCell.Text = "";
            CustomerName.Focus();

        }
        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridView1.Rows[e.RowIndex];
                metroTextBox1.Text = row.Cells[0].Value.ToString();
                CustomerName.Text = row.Cells[1].Value.ToString();
                CustomerAddress.Text = row.Cells[3].Value.ToString();
                CustomerCell.Text = row.Cells[2].Value.ToString();
                metroButton1.Enabled = false;
                btn_Update.Enabled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridView1.Rows[e.RowIndex];
                metroTextBox1.Text = row.Cells[0].Value.ToString();
                CustomerName.Text = row.Cells[1].Value.ToString();
                CustomerAddress.Text = row.Cells[3].Value.ToString();
                CustomerCell.Text = row.Cells[2].Value.ToString();
                metroButton1.Enabled = false;
                btn_Update.Enabled = true;
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridView1.Rows[e.RowIndex];
                metroTextBox1.Text = row.Cells[0].Value.ToString();
                CustomerName.Text = row.Cells[1].Value.ToString();
                CustomerAddress.Text = row.Cells[3].Value.ToString();
                CustomerCell.Text = row.Cells[2].Value.ToString();
                               
                metroButton1.Enabled = false;
                btn_Update.Enabled = true;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (UpdateValid())
            {
                using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Update_Customers", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CustomerName", CustomerName.Text);
                        cmd.Parameters.AddWithValue("@CustomerAddress", CustomerAddress.Text);
                        cmd.Parameters.AddWithValue("@CustomerCellPhone", CustomerCell.Text);
                        cmd.Parameters.AddWithValue("@CustomerID", metroTextBox1.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer Updated Successfully in the System", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        myGridView();                        
                        ClearForm();

                    }
                }
            }
        }

        private bool UpdateValid()
        {
            if (CustomerName.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Sorry! Customer Name not found", "Form Validation Error");
                return false;
            }
            if (CustomerAddress.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Sorry! Customer Address not found", "Form Validation Error");
                return false;
            }
            if (CustomerCell.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Sorry! Customer Cell Number not found", "Form Validation Error");
                return false;
            }
            return true;
        }

        private void btn_Clearform_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
