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
    public partial class CustMessageBox : Form
    {
        private string username = "";
        string connectionString = Properties.Settings.Default.connString;

        public CustMessageBox()
        {
            InitializeComponent();
        }

        public CustMessageBox(string username)
        {
            InitializeComponent();
            this.username = username;

            // insert login record into database
            // insert login record to database
           try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand loginCmd = new SqlCommand())
                    {
                        loginCmd.Connection = conn;
                        loginCmd.CommandType = CommandType.Text;
                        loginCmd.CommandText = "INSERT INTO [Library].[UserLoginHistory] ([Username]) VALUES (@Username);";

                        loginCmd.Parameters.AddWithValue("@Username", username);
                        loginCmd.ExecuteNonQuery();
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Insert new login record faild." + ex.Message);
            }
        }

        private void CustMessageBox_Load(object sender, EventArgs e)
        {
            Welcome.Text = $"Hello {username}\nWelcom to Our Library System!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
