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
    public partial class BorroweBooks : Form
    {
        string connectionString = Properties.Settings.Default.connString;

        public BorroweBooks()
        {
            InitializeComponent();
        }

        private void BorrowBtn_Click(object sender, EventArgs e)
        {
            // get Book Id and borrower id
            string bookID = BookIDText.Text.Trim();
            int borrowerID = (int)BorrowerIDText.Value;
            

            // verify the book id and borrower id valid or not
            if (bookID == "" || borrowerID <= 0)
            {
                MessageBox.Show("Invalid book id or borrower id. Please input the valid value.");
                return;
            }

            using(SqlConnection conn =  new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("BORROWEBOOK", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Input parameter
                    cmd.Parameters.AddWithValue("@BOOID", bookID);
                    cmd.Parameters.AddWithValue("@BORROWERID", borrowerID);
                    cmd.Parameters.AddWithValue("@BorrowedDate",DateTime.Now);
                    cmd.Parameters.AddWithValue("@ReturnDate",DateTime.Now.AddDays(14));

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
                        MessageBox.Show("The book has been successfully borrowed.");
                        // clear the book ID field
                        BookIDText.Text = "";

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
    }
}
