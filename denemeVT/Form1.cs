namespace denemeVT;
using System.Data.SqlClient; // kod kutuphanesi

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void logoutButton_Click(object sender, EventArgs e)
    {
        DialogResult approve = MessageBox.Show("Are you suree to logout?", "Logout Process", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (approve == DialogResult.Yes)
        {
            Application.Exit();
        }
    }

    private void loginButton_Click(object sender, EventArgs e)
    {
       
    }
}
