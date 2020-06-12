using System.Windows.Forms;
namespace MyApplication
{
    public partial class LoginForm : Infrastructure.BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Login...");
        }

        private void resetButton_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Reset...");
        }
    }
}
