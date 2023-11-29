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
    public partial class ManageBooks : Form
    {
        public ManageBooks()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            DisplayBooks displayBooks = new DisplayBooks();
            displayBooks.ShowDialog();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchBook searchBook = new SearchBook();
            searchBook.ShowDialog();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.ShowDialog();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            RemoveBook removeBook = new RemoveBook();
            removeBook.ShowDialog();
        }
    }
}
