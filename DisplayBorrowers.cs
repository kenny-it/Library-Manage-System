using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Manage_System
{
    public partial class DisplayBorrowers : Form
    {
        string connectionString = Properties.Settings.Default.connString;
        public DisplayBorrowers()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DisplayBorrowers_Load(object sender, EventArgs e)
        {
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand("BorrowersList", conn))
                {

                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(comm);
                    DataTable datatable = new DataTable();
                    da.Fill(datatable);
                    this.dataGridView1.DataSource = datatable;

                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
