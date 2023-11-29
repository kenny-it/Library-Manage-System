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
    public partial class SearchBook : Form
    {
        public SearchBook()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // retrieve keywords
            string keyword = keywordText.Text.Trim();
            // sql statement  
            string queryText = "SELECT ID,CONCAT(TITLE,' ',AUTHOR,' ',Publisher,' (',Year,')') AS 'Book Details', CASE WHEN (SELECT COUNT(*) FROM [Library].[Loans]  WHERE ID = BookID) >= 1 THEN 'NO' ELSE 'YES' END AS 'Availability' FROM [Library].[Book] where ";

            // Check the keyword whether contain the double quote or not
            if (keyword.StartsWith("\"") && keyword.EndsWith("\""))
            {
                // trim dobule quote
                string newKeyword = keyword.Replace("\"", "");
                queryText += $" CONCAT(ID,Title,Author,Publisher) COLLATE Latin1_General_CS_AS like '%{newKeyword}%' ";
            }
            // check whether the keyword contain Multiple keywords or not
            else if (keyword.Contains(" "))
            {
                string[] keywords = keyword.Split(' ');
                
                for (int i = 0; i< keywords.Length; i++)
                {
                    if (i == keywords.Length -1)
                    {
                        queryText += $" CONCAT(ID,Title,Author,Publisher) like '%{keywords[i]}%' ";
                    } else
                    {
                        queryText += $" CONCAT(ID,Title,Author,Publisher) like '%{keywords[i]}%' OR";
                    }
                    
                }
            }
            // Only Single keyword
            else
            {
                queryText += $" CONCAT(ID,Title,Author,Publisher) like '%{keyword}%' ";
            }

            // order by title
            queryText += " ORDER BY TITLE;";

            // retrieve data from Database
            string connectionString = Properties.Settings.Default.connString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand(queryText, conn))
                {

                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(comm);
                    DataTable datatable = new DataTable();
                    da.Fill(datatable);
                    this.SearchBookDataGrid.DataSource = datatable;

                }
            }


        }
    }
}
