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
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            DisplayUser displayUser = new DisplayUser();
            displayUser.ShowDialog();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveUserBtn_Click(object sender, EventArgs e)
        {
            RemoveUser removeUser = new RemoveUser();
            removeUser.ShowDialog();
        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            DisplayHistory displayHistory = new DisplayHistory();
            displayHistory.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
