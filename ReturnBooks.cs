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
    public partial class ReturnBooks : Form
    {
        string connectionString = Properties.Settings.Default.connString;
        public ReturnBooks()
        {
            InitializeComponent();
        }

        private void BorrowBtn_Click(object sender, EventArgs e)
        {
            // get Book Id and borrower id
            string bookID = BookIDText.Text.Trim();
            string borrowerID = BorrowerIDText.Text.Trim();


            // verify the book id and borrower id valid or not
            if (bookID == "" || borrowerID == "" )
            {
                MessageBox.Show("Invalid book id or borrower id. Please input the valid value.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("RETURNBOOKS", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Input parameter
                    cmd.Parameters.AddWithValue("@BOOKID", bookID);
                    cmd.Parameters.AddWithValue("@BORROWERID", borrowerID);

                    // Output parameter
                    SqlParameter messageParam = new SqlParameter("@MESSAGE", SqlDbType.NVarChar, 200);
                    messageParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(messageParam);

                    SqlParameter resultParam = new SqlParameter("@RESULT", SqlDbType.Bit);
                    resultParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(resultParam);

                    cmd.ExecuteNonQuery();

                    string message = messageParam.Value.ToString();
                    bool result = (bool)resultParam.Value;


                    if (result)
                    {
                        // if success
                        MessageBox.Show("The book has been successfully returned.");
                        // clear the book ID field
                        BookIDText.Clear();
                        BorrowerIDText.Clear();
                    }
                    else
                    {
                        MessageBox.Show(message);
                    }
                }
            }
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static implicit operator BorroweBooks(ReturnBooks v)
        {
            throw new NotImplementedException();
        }
    }
}
