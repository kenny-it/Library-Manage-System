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
    public partial class SearchBorrower : Form
    {
        string connectionString = Properties.Settings.Default.connString;
        public SearchBorrower()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            int borrowerID = (int)BorrowerIDText.Value;
            // verify borrower id
            if (borrowerID <= 0)
            {
                MessageBox.Show("The borrower ID does not exist.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string queryString = "SELECT borrower.ID,CONCAT(borrower.LastName,' ',borrower.FirstName) AS 'Name',book.ID AS 'Book ID', CONCAT(book.Title,book.Author,book.Publisher,' (',book.Year,') ') AS 'Book Details', loans.BorrowedDate AS 'Borrowed Date'  FROM [Library].[Borrower] borrower left join [Library].[Loans] loans on loans.BorrowerID = borrower.ID left join [Library].[Book] book on book.ID = loans.BookID WHERE borrower.ID = @BorrowerID";
                using (SqlCommand cmd = new SqlCommand(queryString, con))
                {
                    cmd.Parameters.AddWithValue("@BorrowerID", borrowerID);
                    cmd.CommandType = CommandType.Text;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable datatable = new DataTable();
                    da.Fill(datatable);
                    this.BorrowerDetailDataGrid.DataSource = datatable;
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
