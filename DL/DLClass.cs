using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace Hotel_Management_System.DL
{
    class DLClass
    {
        string connectionString = "your connection string";
        SqlConnection con = null;
        public DLClass()
        {
            con = new SqlConnection(connectionString);
        }
        public bool ExecuteQuery(string query, params object[] paramaters)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                int count = 1;
                if (paramaters.Length >= 1)
                {
                    foreach (var paramater in paramaters)
                    {
                        cmd.Parameters.AddWithValue("@" + count, paramater);
                        count++;
                    }
                }
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public SqlDataReader ReturnQuery(string query, params string[] paramaters)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                int count = 1;
                if (paramaters.Length >= 1)
                {
                    foreach (var paramater in paramaters)
                    {
                        cmd.Parameters.AddWithValue("@" + count, paramater);
                        count++;
                    }
                }
                return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}