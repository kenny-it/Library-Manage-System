using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Manage_System
{
    public partial class AddBorrower : Form
    {
        public AddBorrower()
        {
            InitializeComponent();
        }

        //First Name ERROR
        private bool AddB_FNameVaild()
        {
            if (AddB_FName.Text == "")
            {
                MessageBox.Show("Please enter you FirstName.");
                return false;
            }
            return true;

        }

        //Last Name ERROR
        private bool AddB_LNameVaild()
        {
            if (AddB_LName.Text == "")
            {
                MessageBox.Show("Please enter you LastName.");
                return false;
            }
            return true;

        }

        //Contact Number ERROR
        private bool AddB_CNumberVaild()
        {
            if (AddB_CNumber.Text.Trim() == "")
            {
                MessageBox.Show("Please enter you contact Number.");
                return false;
            }
            else if (!(AddB_CNumber.Text.Length == 8))
            {
                MessageBox.Show("Please enter Vaild contact Number.");
                return false;
            }
            else if (!(AddB_CNumber.Text.Substring(0, 1) == "2" || AddB_CNumber.Text.Substring(0, 1) == "3" || AddB_CNumber.Text.Substring(0, 1) == "5" || AddB_CNumber.Text.Substring(0, 1) == "6" || AddB_CNumber.Text.Substring(0, 1) == "9"))
            {
                MessageBox.Show("Please enter Vaild contact Number.");
                return false;
            }
            return true;

        }

        private void AddB_Reset_Click(object sender, EventArgs e)
        {
            AddB_FName.Clear();
            AddB_LName.Clear();
            AddB_CNumber.Clear();
        }

        private void AddB_Enter_Click(object sender, EventArgs e)
        {
            if (AddB_FNameVaild() && AddB_CNumberVaild() && AddB_LNameVaild())
            {
                MessageBox.Show("Ok, Let's create you data",
                    "Note",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                String FName = AddB_FName.Text.ToLower();
                TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                FName = textInfo.ToTitleCase(FName);
                String LName = AddB_LName.Text.ToUpper();
                String CNumber = AddB_CNumber.Text;
                //connection
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    //connection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("AddNewBorrower", connection))
                    {
                        //FirstName
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar, 30));
                        sqlCommand.Parameters["@FirstName"].Value = FName;
                        //LastName
                        sqlCommand.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar, 10));
                        sqlCommand.Parameters["@LastName"].Value = LName;
                        //ContactNumber
                        sqlCommand.Parameters.Add(new SqlParameter("@Contact", SqlDbType.Int));
                        sqlCommand.Parameters["@Contact"].Value = CNumber;

                        try
                        {
                            connection.Open();
                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Borrower account has been created.");
                            this.Close();
                        }
                        catch
                        {
                            MessageBox.Show("ID was not returned. Account could not be created.");
                        }
                       
                    }

                }

            }
   
        }
    }
}
