using System.Configuration;
using Win.Forms.Apps.Services;

namespace Win.Forms.Apps
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var configuration = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            MessageBox.Show(configuration);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserServices us = new UserServices();
            var res = us.Login(txtUsername.Text, txtPassword.Text);
            if (res.Item1)
            {
                //navigate to a new form
            }
            else
            {
                MessageBox.Show(res.Item2);
            }
        }
    }
}