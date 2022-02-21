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
using PointofSaleSoftware.General;

namespace PointofSaleSoftware.Screens.ProductsF
{
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            dataGridView1.Height = Height - 300;
            dataGridView1.Width = Width - 200;
            mySuppliersView();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void CloseForm()
        {
            this.Hide();
            POS dashboardForm = new POS();
            dashboardForm.Show();
        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
        private void mySuppliersView()
        {
            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("USP_SUPPLIERINFO", con))
                {
                    DataTable dt = new DataTable();
                    SqlCommand myCmd = new SqlCommand("USP_SUPPLIERINFO", con);
                    myCmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(myCmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].Width = 30;
                    dataGridView1.Columns[1].Width = 30;
                    dataGridView1.Columns[1].Width = 100;
                    dataGridView1.Columns[2].Width = 150;
                    dataGridView1.Columns[3].Width = 100;

                }
            }
        }
        private void ClearSupp()
        {
            Supp_Code.Text = "";
            Supp_Name.Text = "";
            Supp_Address.Text = "";
            Supp_CellNumber.Text = "";
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearSupp();
        }
        private bool SValid()
        {
            if (Supp_Code.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please Provide Supplier Code", "Data Validation Error");
                Supp_Code.Focus();
                return false;
            }
            if (Supp_Name.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please Provide Supplier Name", "Data Validation Error");
                Supp_Name.Focus();
                return false;
            }
            if (Supp_Address.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please Provide Supplier Address", "Data Validation Error");
                Supp_Address.Focus();
                return false;
            }
            if (Supp_CellNumber.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please Provide Supplier Cell Number", "Data Validation Error");
                Supp_CellNumber.Focus();
                return false;
            }
            return true;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (SValid())
            {
                using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("USP_INSERT_SUPPLIERS", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@SUPPCODE", Supp_Code.Text);
                        cmd.Parameters.AddWithValue("@SUPPNAME", Supp_Name.Text);
                        cmd.Parameters.AddWithValue("@SUPPADD", Supp_Address.Text);
                        cmd.Parameters.AddWithValue("@SUPPCELL", Supp_CellNumber.Text);
                        con.Open();
                        int id = Convert.ToInt32(cmd.ExecuteScalar());
                        MessageBox.Show("New Supplier has been created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mySuppliersView();
                        ClearSupp();
                        Supp_Code.Focus();

                    }
                }
            }
        }

        private void Supp_Address_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.KeyChar = Char.ToUpper(e.KeyChar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row != null)
                {
                    SuppID.Text = row.Cells[0].Value.ToString();
                    Supp_Code.Text = row.Cells[1].Value.ToString();
                    Supp_Name.Text = row.Cells[2].Value.ToString();
                    Supp_Address.Text = row.Cells[3].Value.ToString();
                    Supp_CellNumber.Text = row.Cells[4].Value.ToString();
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (SValid())
            {
                using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("USP_UPDATE_SUPPLIERS", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@SUPPCODE", Supp_Code.Text);
                        cmd.Parameters.AddWithValue("@SUPPNAME", Supp_Name.Text);
                        cmd.Parameters.AddWithValue("@SUPPADDRESS", Supp_Address.Text);
                        cmd.Parameters.AddWithValue("@SUPPCELL", Supp_CellNumber.Text);
                        cmd.Parameters.AddWithValue("@SUPPID", SuppID.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Supplier Updated Successfully in the System", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mySuppliersView();
                        ClearSupp();

                    }

                }
            }
        }
    }
}

    
