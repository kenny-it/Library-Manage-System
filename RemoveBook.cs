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
    public partial class RemoveBook : Form
    {
        string connectionString = Properties.Settings.Default.connString;

        public RemoveBook()
        {
            InitializeComponent();
        }

        private void WaitForUserConfirm(string bookId, string bookDetails, string availability)
        {
            // displays the book details and prompts for user’s confirmation to delete
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            string caption = "Are you sure you want to delete the book?";
            DialogResult result;

            // Display the MessageBox
            result = MessageBox.Show(
                $"BOOK ID: {bookId} \nBook Details: {bookDetails} \nAvailability: {availability}\n",
                caption, buttons);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using(SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = $"DELETE FROM [Library].[Book] WHERE ID=@bookId";
                        cmd.Parameters.AddWithValue("@bookId", bookId);

                        cmd.ExecuteNonQuery();
                        
                    }
                }
                this.Close();
            }
                
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            // Retrieve Book ID
            string bookID = BookIDText.Text.Trim();
            if(bookID == "")
            {
                MessageBox.Show("Please input the Book ID.");
                return;
            }

            // retrieve result from store procedure
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand("REMOVEBOOK",conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Input parameter
                    cmd.Parameters.AddWithValue("@ID", bookID);
                    // Output parameter
                    SqlParameter bookDetailsParam = new SqlParameter("@BOOKDETAIL", SqlDbType.NVarChar, 300);
                    bookDetailsParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(bookDetailsParam);

                    SqlParameter isAvailableParam = new SqlParameter("@ISAVAIABLE", SqlDbType.NVarChar, 10);
                    isAvailableParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(isAvailableParam);

                    SqlParameter messageParam = new SqlParameter("@MESSAGE", SqlDbType.NVarChar, 100);
                    messageParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(messageParam);

                    SqlParameter resultParam = new SqlParameter("@RESULT", SqlDbType.Bit);
                    resultParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(resultParam);

                    cmd.ExecuteNonQuery();

                    string bookDetails = bookDetailsParam.Value.ToString();
                    string availability = isAvailableParam.Value.ToString();
                    string message = messageParam.Value.ToString();
                    bool result = (bool) resultParam.Value;

                    if (result)
                    {
                        // Verify user confirm
                        WaitForUserConfirm(bookID, bookDetails, availability);
                       
                    }else
                    {
                        // the book ID is not found, or the book is not available
                        MessageBox.Show(message);
                    }
                }
            }
        }
    }
}
