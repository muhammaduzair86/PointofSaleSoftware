using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointofSaleSoftware.General
{
    public static class Data
    {
        public static DataTable RunSelectQuery(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    }
            }

            return dt;
        }

        

        //insert, delete, update queries
        public static int RunActionQuery(string query, CommandType commandType = CommandType.Text)
        {
            int records = 0;
            SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString());
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = commandType;
            try
            {
                con.Open();
                records = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }



            return records;
        }

        //Data Binding in Combobox
        public static void Bind(ComboBox controlName, string query, string displayMember, string valueMember)
        {           
            controlName.ValueMember = valueMember;
            controlName.DisplayMember = displayMember;
            controlName.DataSource = RunSelectQuery(query);
            controlName.SelectedIndex = -1;
        }

        public static decimal SaleValueCalc(string val1,string val2)
        {
            decimal qty=0, salerate=0, rowAmount=0;
            decimal.TryParse(val1, out qty);
            decimal.TryParse(val2, out salerate);
            rowAmount = qty * salerate;
            return rowAmount;                       
        }

    }
}
