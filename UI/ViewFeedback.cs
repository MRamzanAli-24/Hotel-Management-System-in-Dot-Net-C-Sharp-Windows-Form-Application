using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_Management_System.DL;

namespace Hotel_Management_System.UI
{
    public partial class ViewFeedback : Form
    {
        public ViewFeedback()
        {
            InitializeComponent();
        }
        public void LoadFromDB()
        {
            var reader = new DLClass().ReturnQuery("select * from FeedBack;");
            if (reader!=null)
            {
                dataGridViewFeadback.Rows.Clear();
                while (reader.Read())
                {
                    dataGridViewFeadback.Rows.Add(reader["id"].ToString(), reader["customerName"].ToString(), reader["customerPhNo"].ToString(), reader["feedback"].ToString(), "Delete");
                }
            }
        }
        private void dataGridViewFeadback_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>-1&&e.ColumnIndex== 4)
            {
                string id = dataGridViewFeadback.Rows[e.RowIndex].Cells[0].Value.ToString() ?? "";
                if (MessageBox.Show("Do you want to Delete the record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool check = new DLClass().ExecuteQuery("delete from FeedBack where id=@1", id);
                    if (check)
                    {
                        MessageBox.Show("Record Deleted Successfully");
                        LoadFromDB();
                        FetchDB.GetFeedBack();
                    }
                }
            }
        }

        private void ViewFeedback_Load(object sender, EventArgs e)
        {
           LoadFromDB();
        }
    }
}
