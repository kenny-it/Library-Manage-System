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
    public partial class MemberList : Form
    {
        string connectionString = Properties.Settings.Default.connString;
        public MemberList()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MemberList_Load(object sender, EventArgs e)
        {
           
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = "SELECT StudentID,StudentName,Class,TutorialGroup FROM [Library].[Members] ORDER BY StudentName";
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(comm);
                    DataTable datatable = new DataTable();
                    da.Fill(datatable);
                    this.MemberListView.DataSource = datatable;

                }
            }
        }
    }
}
