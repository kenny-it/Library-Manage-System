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
    public partial class DisplayUser : Form
    {
        string connectionString = Properties.Settings.Default.connString;
        public DisplayUser()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DiaplayUserDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DisplayUser_Load(object sender, EventArgs e)
        {
            // display user list
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = "select ID,Username,CreateDate FROM [Library].[User]";
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;

                    SqlDataAdapter da = new SqlDataAdapter(comm);
                    DataTable datatable = new DataTable();
                    da.Fill(datatable);
                    DiaplayUserDataGrid.DataSource = datatable;

                }
            }
        }
    }
}
