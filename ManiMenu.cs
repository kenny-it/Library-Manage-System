namespace Library_Manage_System
{
    public partial class ManiMenu : Form
    {
        public ManiMenu()
        {
            InitializeComponent();
        }

        private void ManiMenu_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            DialogResult result = login.ShowDialog();
            if (result != DialogResult.OK)
            {
                this.Close();
            }
        }

        private void R7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void R1_Click(object sender, EventArgs e)
        {
            // display Manage Books
            ManageBooks manageBooks = new ManageBooks();
            manageBooks.ShowDialog(this);
        }

        private void R2_Click(object sender, EventArgs e)
        {
            ManageBorrowers manageBorrowers = new ManageBorrowers();
            manageBorrowers.ShowDialog(this);
        }

        private void R6_Click(object sender, EventArgs e)
        {
            MemberList memberList = new MemberList();
            memberList.ShowDialog(this);
        }

        private void R3_Click(object sender, EventArgs e)
        {
            BorroweBooks borrowes = new BorroweBooks();
            borrowes.ShowDialog(this);
        }

        private void R5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Useful feature is design to manage the login users.");
            ManageUser manageUser = new ManageUser();
            manageUser.ShowDialog(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void R4_Click(object sender, EventArgs e)
        {
            ReturnBooks returnBooks = new ReturnBooks();
            returnBooks.ShowDialog(this);
        }
    }
}