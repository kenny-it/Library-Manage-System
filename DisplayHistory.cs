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

namespace Library_Manage_System
{
    public partial class DisplayHistory : Form
    {
        string connectionString = Properties.Settings.Default.connString;
        public DisplayHistory()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayHistory_Load(object sender, EventArgs e)
        {
            // display user login history
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = "select ID, Username, LoginDate FROM [Library].[UserLoginHistory] ORDER BY LoginDate desc";
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;

                    SqlDataAdapter da = new SqlDataAdapter(comm);
                    DataTable datatable = new DataTable();
                    da.Fill(datatable);
                    HistoryDataGrid.DataSource = datatable;

                }
            }
        }
    }
}
