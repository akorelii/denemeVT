namespace denemeVT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            DialogResult approval = MessageBox.Show("Are you sure to logout?", "Logout Process", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(approval == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
