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
    public partial class AddUser : Form
    {
        string connectionString = Properties.Settings.Default.connString;
        public AddUser()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            //Add User
            // check user name and password
            string username = UsernameText.Text.Trim();
            string password = PasswordText.Text.Trim();

            if (username == "" || password == "") 
            {
                MessageBox.Show("Invalid input. The Username or Password cannot be empty.");
                return;
            }

            // check password length 
            // must be more than 8 character
            if (password.Length < 8) {
                MessageBox.Show("The Password length must be more than 8 character.");
                return;
            }

            // The length of username , password must be less than 20 character
            if (username.Length > 20 || password.Length > 20)
            {
                MessageBox.Show("The Username or Password length must be less than or equal to 20 character.");
                return;
            }


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("AddLoginUser", conn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);


                    // Create the Output parameters for error message and Result
                    SqlParameter errorMessageParam = new SqlParameter("@ERRORMESSAGE", SqlDbType.NVarChar, 100);
                    errorMessageParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(errorMessageParam);

                    SqlParameter resultParam = new SqlParameter("@RESULT", SqlDbType.Bit);
                    resultParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(resultParam);

                    // Execute the stored procedure
                    cmd.ExecuteNonQuery();

                    // Retrieve the error messae and Result from the output parameters
                    string errorMessage = errorMessageParam.Value.ToString();
                    bool result = (bool)resultParam.Value;

                    if (result)
                    {
                        MessageBox.Show("Create New User success!");
                        // Clear field
                        UsernameText.Clear();
                        PasswordText.Clear();
                    }
                    else
                    {
                        MessageBox.Show(errorMessage);
                    }
                }
            }
        }
    }
}
