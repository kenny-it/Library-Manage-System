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
    public partial class Login : Form
    {
        string connectionString = Properties.Settings.Default.connString;
       
        public Login()
        {
            InitializeComponent();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            UserNameText.Clear();
            PasswordText.Clear();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // get username and password
            string username = UserNameText.Text.Trim();
            string password = PasswordText.Text.Trim();
            // user id
            int id = 0;

            // verify username and password
            if (username == null || password == null || username == "" || password == "")
            {
                MessageBox.Show("The username or password can not be empty.");
                return;
            }

            // login...
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = "select top 1 id,username FROM [Library].[User] WHERE Username=@username and Password=@password";
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;

                    SqlParameter userParam = new SqlParameter("@username",SqlDbType.NVarChar,20);
                    userParam.Value = username;
                    userParam.Direction = ParameterDirection.Input;

                    SqlParameter passParam = new SqlParameter("@password", SqlDbType.NVarChar, 20);
                    passParam.Value = password;
                    passParam.Direction = ParameterDirection.Input;
                    
                    comm.Parameters.Add(userParam);
                    comm.Parameters.Add(passParam);

                    SqlDataReader dr =  comm.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            id = dr.IsDBNull(dr.GetOrdinal("id")) ? 0 : dr.GetInt32("id");
                        }
                    }

                    // if username exist
                    if (id > 0)
                    {
                        // Display welcome message
                        CustMessageBox custMessageBox = new CustMessageBox(username);
                        custMessageBox.ShowDialog(this);
                        this.DialogResult = DialogResult.OK;
                        // Insert login record into login history, this step will be done in message dialog.
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password incorrect.");
                    }
                    

                }
            }
        }
    }
}
