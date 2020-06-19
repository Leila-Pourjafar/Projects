
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplication
{
    public partial class RegisterForm : Infrastructure.BaseForm
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, System.EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;
            string errorMessage = string.Empty;

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
            if (string.IsNullOrEmpty(usernameTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text))
            {
                System.Windows.Forms.MessageBox.Show("وارد کردن نام کاربری و رمز عبور اجباری است ");
                return;
            }

            if (usernameTextBox.Text.Length < 6)
            {
                errorMessage += "نام کاربری حداقل 6 کاراکتر میباشد";
            }
            if (passwordTextBox.Text.Length < 8)
            {
                errorMessage += Environment.NewLine + "رمز عبور حداقل 8 کاراکتر میباشد";
            }
            if (string.IsNullOrEmpty(errorMessage) == false)
            {
                System.Windows.Forms.MessageBox.Show(errorMessage);
                Reset();
                return;
            }
            try
            {
                databaseContext = new Models.DatabaseContext();

                Models.User user = databaseContext.Users
                    .Where(x => x.Username.ToLower() == usernameTextBox.Text.ToLower())
                    .FirstOrDefault();

                if (user != null)
                {
                    errorMessage += "این نام کاربری موجود است";
                    System.Windows.Forms.MessageBox.Show(errorMessage);
                    Reset();
                    return;
                }

                user = new Models.User()
                {
                    Username = usernameTextBox.Text,
                    Password = passwordTextBox.Text,
                    FullName = fullnameTextBox.Text,
                };

                databaseContext.Users.Add(user);
                databaseContext.SaveChanges();
                System.Windows.Forms.MessageBox.Show("اطلاعات با موفقیت ثبت شد");
                return;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                Reset();
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

        public void Reset()
        {
            usernameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
            fullnameTextBox.Text = string.Empty;
            usernameTextBox.Focus();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
