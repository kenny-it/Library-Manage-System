using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Manage_System
{
    public partial class RemoveUser : Form
    {

        string connectionString = Properties.Settings.Default.connString;
        public RemoveUser()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // get user name
            string username = UsernameText.Text.Trim();
            if (username.Length == 0 )
            {
                MessageBox.Show("The username Can not be empty.");
                return;
            }

            // retrieve result from store procedure
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT id FROM [Library].[User] WHERE Username=@username;";

                    cmd.Parameters.AddWithValue("@username", username);
                    object results = cmd.ExecuteScalar();


                    if(results != null)
                    {
                        // promtp to ask user confirm
                        // displays the book details and prompts for user’s confirmation to delete
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        string caption = "Are you sure you want to delete the user?";
                        DialogResult result;

                        // Display the MessageBox
                        result = MessageBox.Show(
                            $"UserName: {username}\n",
                            caption, buttons);
                        if (result == DialogResult.Yes)
                        {
                            using (SqlCommand command = new SqlCommand())
                            {
                                command.Connection = conn;
                                command.CommandType = CommandType.Text;
                                command.CommandText = $"DELETE FROM [Library].[User] WHERE Username=@username";
                                command.Parameters.AddWithValue("@username", username);
                                command.ExecuteNonQuery();
                                MessageBox.Show("Delete user Success.");
                                UsernameText.Clear();
                            }
                        }
                    } else
                    {
                        MessageBox.Show("The username does not exist in the database.");
                        return;
                    }
                   
                   
                }
            }

        }
    }
}
