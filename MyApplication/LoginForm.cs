using System.Data.Entity.Infrastructure;
using System.Linq;
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
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) ||
                string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                usernameTextBox.Text =
                    usernameTextBox.Text.Replace("", string.Empty);

                passwordTextBox.Text = 
                    passwordTextBox.Text.Replace("", string.Empty);
                System.Windows.Forms.MessageBox.Show("نام کاربری و رمز عبور اجباری می باشد");

                if (usernameTextBox.Text == string.Empty)
                {
                    usernameTextBox.Focus();
                }
                else
                {
                    passwordTextBox.Focus();
                }

                return;
            }
            Models.DatabaseContext databaseContext = null;
            try
            {
                databaseContext = new Models.DatabaseContext();

                var user = databaseContext.Users
                    .Where(x => x.Username.ToLower() == usernameTextBox.Text.ToLower())
                    .FirstOrDefault();
                if (user != null)
                {
                    if (string.Compare(user.Password, passwordTextBox.Text, ignoreCase: false) != 0)
                    {
                        MessageBox.Show("نام کاربری یا رمز عبور اشتباه است ");
                        Reset();
                        return;
                    }

                    if (user.IsActive == false)
                    {
                        MessageBox.Show("شما نمیتوانید وارد سیستم شوید با مدیر سیستم تماس بگیرید ");
                        Reset();
                        return;
                    }
                    Hide();
                    Infrastructure.Utility.AuthenticatedUser = user;
                    Infrastructure.Utility.MainForm.Show();
                   // MessageBox.Show("خوش آمدید");
                    //return;
                }

                else
                {
                    MessageBox.Show("نام کاربری یا رمز عبور اشتباه است ");
                    Reset();
                    return;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                return;
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                }
            }
        }

        private void resetButton_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Reset...");
        }

        public void Reset()
        {
            usernameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
            usernameTextBox.Focus();
        }

        private void registerbutton_Click(object sender, System.EventArgs e)
        {
            Infrastructure.Utility.RegisterForm.Show();
        }
    }
}
