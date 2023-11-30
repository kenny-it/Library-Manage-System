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
    public partial class RemoveBorrower : Form
    {
        string connectionString = Properties.Settings.Default.connString;
        public RemoveBorrower()
        {
            InitializeComponent();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            // Verify borrower id
            int borrowerID = (int)BorrowerIDText.Value;
            if (borrowerID <= 0 )
            {
                MessageBox.Show("Invalid borrower ID. Please make sure you entered the correct ID.");
                return;
            }

            // retiieve from database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("REMOVEBORROWER", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Input parameter
                    cmd.Parameters.AddWithValue("@BORROWERID", borrowerID);   
                    // Output parameter
                    SqlParameter messageParam = new SqlParameter("@MESSAGE",SqlDbType.NVarChar,200);
                    messageParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(messageParam);

                    SqlParameter resultParam = new SqlParameter("@RESULT", SqlDbType.Bit);
                    resultParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(resultParam);

                    SqlParameter nameParam = new SqlParameter("@NAME", SqlDbType.NVarChar, 50);
                    nameParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(nameParam);

                    SqlParameter contactParam = new SqlParameter("@CONTACT", SqlDbType.NVarChar, 20);
                    contactParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(contactParam);

                    cmd.ExecuteNonQuery();

                    string message = messageParam.Value.ToString();
                    string name = nameParam.Value.ToString();
                    string contact = contactParam.Value.ToString();
                    bool result = (bool) resultParam.Value;

                    if (result)
                    {
                        // Verify user confirm
                        // displays the book details and prompts for user’s confirmation to delete
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        string caption = "Are you sure you want to delete this borrower?";
                        DialogResult dialogResult;

                        // Display the MessageBox
                        dialogResult = MessageBox.Show(
                            $"Borrower ID: {borrowerID} \nName: {name} \nContact Number: {contact}\n",
                            caption, buttons);
                        if (dialogResult == DialogResult.Yes)
                        {
                            using (SqlCommand command = new SqlCommand())
                            {
                                command.Connection = conn;
                                command.CommandType = CommandType.Text;
                                command.CommandText = $"DELETE FROM [Library].[Borrower] WHERE ID=@borrowerID";
                                command.Parameters.AddWithValue("@borrowerID", borrowerID);

                                command.ExecuteNonQuery();

                            }
                            this.Close();
                            MessageBox.Show($"Borrower {name} has been successfully removed from the system.");
                        }

                    } else
                    {
                        MessageBox.Show(message);
                        return;
                    }


                }
            }
        }
    }
}
