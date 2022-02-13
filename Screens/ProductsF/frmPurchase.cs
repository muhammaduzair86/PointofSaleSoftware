using MetroFramework.Forms;
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
    public partial class frmPurchase : MetroForm
    {
        public int EditId = 0;
        public frmPurchase()
        {
            InitializeComponent();
        }

        private void frmPurchase_Load(object sender, EventArgs e)
        {
            Bindings();
            //initialize datagridview datasource
            string query = "select * from PurchaseDetail where PurchaseDetailID=-1";
            DataTable dt = Data.RunSelectQuery(query);
            dgv_Purd.DataSource = dt;
            dgv_Purd.Columns[0].Visible = false;
            dgv_Purd.Columns[1].Visible = false;

            //check EditMode
            if (this.EditId > 0)
            {
                query = "select * from Purchase where PurchaseID=" + this.EditId;
                dt = Data.RunSelectQuery(query);
                if (dt != null && dt.Rows.Count > 0)
                {
                    txtPurchaseID.Text = this.EditId.ToString();
                    dtpPurchaseDate.Value = Convert.ToDateTime(dt.Rows[0]["PurchaseDate"]);
                    cmbSupplierID.SelectedValue = Convert.ToInt32(dt.Rows[0]["SupplierID"]);
                    txtTotalAmount.Text = Convert.ToDouble(dt.Rows[0]["TotalAmount"]).ToString("n2");
                    query = "select * from PurchaseDetail where PurchaseID=" + this.EditId;
                    dgv_Purd.DataSource = Data.RunSelectQuery(query);
                    btnSave.Text = "Update";
                }
            }
        }

        private void Bindings()
        {
            Data.Bind(cmbProductID, "select ProductID,Name from Products", "Name", "ProductID");
            Data.Bind(cmbSupplierID, "select Supp_ID, Supp_Name from Suppliers", "Supp_Name", "Supp_ID");
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            if (VPurchase())
            {
                double qty = 0, rate = 0;
                if (cmbProductID.SelectedIndex < 0)
                    MessageBox.Show("Select a Product.");
                else if (string.IsNullOrEmpty(txtPurQty.Text) || !Double.TryParse(txtPurQty.Text, out qty))
                    MessageBox.Show("Type a valid value in Quantity field.");
                else if (string.IsNullOrEmpty(txtRate.Text) || !Double.TryParse(txtRate.Text, out rate))
                    MessageBox.Show("Type a valid value in Rate field.");
                else
                {
                    double amount = qty * rate;
                    if (amount <= 0)
                        MessageBox.Show("Type valid values in Quantity and Rate fields.");
                    else
                    {
                        DataTable dt = (DataTable)dgv_Purd.DataSource;
                        DataRow dr = dt.NewRow();
                        dr["PurchaseDetailID"] = DBNull.Value;
                        dr["PurchaseID"] = DBNull.Value;
                        if (!string.IsNullOrEmpty(txtPurchaseID.Text))
                            dr["PurchaseID"] = txtPurchaseID.Text;
                        dr["ProductID"] = Convert.ToInt32(cmbProductID.SelectedValue);
                        dr["Quantity"] = Convert.ToDouble(txtPurQty.Text);
                        dr["PurchasePrice"] = Convert.ToDouble(txtRate.Text);
                        dr["TotalPrice"] = amount;
                        dt.Rows.Add(dr);
                        dgv_Purd.DataSource = dt;
                        this.CalculateTotals();
                    }
                }
            }
        }

        private void CalculateTotals()
        {
            double total = 0;
            DataTable dt = (DataTable)dgv_Purd.DataSource;
            foreach (DataRow dataRow in dt.Rows)
            {
                if (dataRow.RowState != DataRowState.Deleted)
                    total += Convert.ToDouble(dataRow["TotalPrice"]);
            }
            txtTotalAmount.Text = total.ToString("n2");
        }

        private void txtPurQty_TextChanged(object sender, EventArgs e)
        {
            double qty = 0, rate = 0, amount = 0;
            if (Double.TryParse(txtPurQty.Text, out qty) && Double.TryParse(txtRate.Text, out rate))
                amount = qty * rate;
            txtAmount.Text = amount.ToString("n2");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = "";
            if (this.EditId == 0)
            {
                query = @"insert into Purchase (PurchaseDate, SupplierID, TotalAmount)
                    values('" + dtpPurchaseDate.Value.ToString("yyyy-MM-dd") + @"'
                    ,'" + cmbSupplierID.SelectedValue + @"'
                    ,'" + txtTotalAmount.Text + "'); select scope_identity()";
                int pid = Data.RunActionQuery(query);
                //if (pid > 0)
                //{
                DataTable dt = (DataTable)dgv_Purd.DataSource;
                foreach (DataRow dataRow in dt.Rows)
                {
                    if (dataRow.RowState != DataRowState.Deleted)
                    {
                        query = @"insert into PurchaseDetail (PurchaseID, ProductID, Quantity, PurchasePrice, TotalPrice)
                            values('" + pid + @"'
                            , '" + dataRow["ProductID"] + @"'
                            , '" + dataRow["Quantity"] + @"'
                            , '" + dataRow["PurchasePrice"] + @"'
                            , '" + dataRow["TotalPrice"] + @"'
                            )";
                        Data.RunActionQuery(query);
                    }
                }
            }
            else
            {
                query = @"update Purchase 
                        set PurchaseDate='" + dtpPurchaseDate.Value.ToString("yyyy-MM-dd") + @"'
                        , SupplierID='" + Convert.ToInt32(cmbSupplierID.SelectedValue) + @"'
                        , TotalAmount='" + Convert.ToDouble(txtTotalAmount.Text) + @"'
                         where PurchaseID=" + this.EditId;
                Data.RunActionQuery(query);
                //insert or update grid
                DataTable dt = (DataTable)dgv_Purd.DataSource;
                foreach (DataRow dataRow in dt.Rows)
                {
                    if (dataRow.RowState != DataRowState.Deleted)
                    {
                        int pdId = 0;
                        if (dataRow[0] != DBNull.Value && dataRow[0].ToString() != String.Empty)
                        {
                            pdId = Convert.ToInt32(dataRow[0]);
                            query = @"update PurchaseDetail
                                set PurchaseID='" + this.EditId + @"'
                                , ProductID='" + dataRow["ProductID"].ToString() + @"'
                                , Quantity='" + dataRow["Quantity"] + @"'
                                , PurchasePrice='" + dataRow["PurchasePrice"] + @"'
                                , TotalPrice='" + dataRow["TotalPrice"] + @"'
                                where PurchaseDetailId = " + pdId;
                        }
                        else
                        {
                            query = @"insert into PurchaseDetail (PurchaseID, ProductID, Quantity, PurchasePrice, TotalPrice)
                            values('" + this.EditId + @"'
                            , '" + dataRow["ProductID"] + @"'
                            , '" + dataRow["Quantity"] + @"'
                            , '" + dataRow["PurchasePrice"] + @"'
                            , '" + dataRow["TotalPrice"] + @"'
                            )";
                        }

                        Data.RunActionQuery(query);
                    }
                }
            }


            if (this.EditId > 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Saved.");
            }
            
        }


        //}


        private bool VPurchase()
        {
            if (string.IsNullOrEmpty(dtpPurchaseDate.Text))
            {
                MessageBox.Show("Please Enter Purchase Date");
                return false;
                //dtpPurchaseDate.Focus();                    
            }
            if (string.IsNullOrEmpty(cmbSupplierID.Text))
            {
                MessageBox.Show("Please Select Supplier");
                return false;

            }
            if (string.IsNullOrEmpty(cmbProductID.Text))
            {
                MessageBox.Show("Please Select Product");
                return false;

            }
            if (string.IsNullOrEmpty(txtPurQty.Text))
            {
                MessageBox.Show("Please Provide Purchased Quantity !");
                return false;

            }
            if (string.IsNullOrEmpty(txtRate.Text))
            {
                MessageBox.Show("Please Provie Purchase Rate");
                return false;

            }
            return true;
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (dgv_Purd.SelectedRows.Count > 0)
            {
                //remove it from Database first
                if (dgv_Purd.SelectedRows[0].Cells[0].Value != null)
                {
                    int pdId = Convert.ToInt32(dgv_Purd.SelectedRows[0].Cells[0].Value);
                    string query = "delete from PurchaseDetail where PurchaseDetailID=" + pdId;
                    Data.RunActionQuery(query);
                }

                dgv_Purd.Rows.Remove(dgv_Purd.SelectedRows[0]);

                this.CalculateTotals();
            }
        }

        private void dgv_Purd_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            

        }

                private void dgv_Purd_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dgv_Purd_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            this.Text = e.ColumnIndex.ToString();
        }
    }
}



