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
using PointofSaleSoftware.Screens;

namespace PointofSaleSoftware
{
    public partial class frmLoginWindow : MetroFramework.Forms.MetroForm
    {
        public frmLoginWindow()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(isValid())
            {
                using (SqlConnection conn = new SqlConnection(ApplicationSetting.ConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Login_VerifyLoginDetails",conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserName", LoginTextBox.Text);
                        cmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text);
                        
                        conn.Open();

                        SqlDataReader sdr = cmd.ExecuteReader();

                        if (sdr.Read())
                        {
                            this.Hide();
                            POS df = new POS();
                            df.Show();

                        }
                        else
                        {
                            MessageBox.Show("User Name or Password is Incorrect", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                     
                         }
        }
        private bool isValid()
        {
            if(LoginTextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("User Name is required", "Form Validation Error");
                return false;
            }
            // Validation for Password field
            if (PasswordTextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Password is required", "Form Validation Error");
                return false;
            }
            return true;
        }
    }
}
