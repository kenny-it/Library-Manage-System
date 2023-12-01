using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Manage_System
{
    public partial class AddBook : Form
    {
        string connectionString = Properties.Settings.Default.connString;

        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            // check whether year is positive or not
            int year = (int)YearText.Value;
            if (year <= 0 || year > DateTime.Now.Year) {
                MessageBox.Show("Invalid input. Please enter a valid year that is not negative and does not exceed the current year.");
                return;
            }
            
            // check Tile, Author, Publisher is empty or not
            if (IDText.Text.Trim() == "" || TitleText.Text.Trim() == "" || AuthorText.Text.Trim() == "" || PublisherText.Text.Trim() == "")
            {
                MessageBox.Show("The ID, title, author, and publisher cannot be empty."); return;
            }

            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("ADDBOOK", conn))
                {
                   
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID",IDText.Text.Trim());
                        cmd.Parameters.AddWithValue("@TITLE",TitleText.Text.Trim());
                        cmd.Parameters.AddWithValue("@AUTHOR",AuthorText.Text.Trim());
                        cmd.Parameters.AddWithValue("@PUBLISHER",PublisherText.Text.Trim());
                        cmd.Parameters.AddWithValue("@YEAR", year);

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
                        MessageBox.Show("Insert into book success!");
                        // Clear input
                        IDText.Clear();
                        TitleText.Clear();
                        AuthorText.Clear();
                        PublisherText.Clear();
                        YearText.Value = 0;
                    } else
                    {
                        MessageBox.Show(errorMessage);
                    }


                }
            }

            this.Close();
        }
    }
}
