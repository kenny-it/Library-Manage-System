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
            // Display welcome message
            CustMessageBox custMessageBox = new CustMessageBox();
            custMessageBox.ShowDialog(this);
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
    }
}