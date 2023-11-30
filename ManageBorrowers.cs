using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Manage_System
{
    public partial class ManageBorrowers : Form
    {
        public ManageBorrowers()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            DisplayBorrowers displayBorrowers = new DisplayBorrowers();
            displayBorrowers.ShowDialog();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchBorrower searchBorrower = new SearchBorrower();
            searchBorrower.ShowDialog();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            RemoveBorrower removeBorrower = new RemoveBorrower();
            removeBorrower.ShowDialog();
        }
    }
}
