namespace WinForms.App
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTextBoxes();
        }

        private void ResetTextBoxes()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void Login()
        {
            if (txtUsername.Text == "chandan")
            {
                if (txtPassword.Text == "Test@123")
                {
                    MessageBox.Show("Loggedin successfully");
                    //navigate to new form
                    MainForm mf = new MainForm();
                    mf.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password doesnot match");
                }
            }
            else
            {
                MessageBox.Show("Username not matched");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}