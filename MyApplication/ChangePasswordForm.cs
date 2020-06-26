
namespace MyApplication
{
    public partial class ChangePasswordForm : Infrastructure.BaseForm
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void changePasswordButton_Click(object sender, System.EventArgs e)
        {
            string errorMessage = string.Empty;
            if (string.IsNullOrWhiteSpace(oldpasswordTextBox.Text)
                || string.IsNullOrWhiteSpace(newpasswordTextBox.Text)
                || string.IsNullOrWhiteSpace(confirmPasswordTextBox.Text))
            {
                errorMessage = "فیلدهای الزامی را پر کنید ";

            }

            else
            {

                if (confirmPasswordTextBox.Text.Length < 8)
                {
                    if (errorMessage != string.Empty)
                    {
                        errorMessage += System.Environment.NewLine;
                    }

                    errorMessage +=
                        "طول رمز عبور جدید حداقل8 کاراکتر می باشد.";
                }

                if (string.Compare(confirmPasswordTextBox.Text, newpasswordTextBox.Text, ignoreCase: false) != 0)
                {
                    if (errorMessage != string.Empty)
                    {
                        errorMessage += System.Environment.NewLine;
                    }

                    errorMessage +=
                        "رمز عبور جدید و تکرار رمز برابر نیست ";
                }
            }

            if (errorMessage != string.Empty)
            {
                System.Windows.Forms.MessageBox.Show(errorMessage);

                oldpasswordTextBox.Focus();

                return;
            }
            else
            {
                Models.DatabaseContext databaseContext = null;
                try
                {
                    Models.User user = databaseContext.Users
                        .Find(Infrastructure.Utility.AuthenticatedUser.Id);
                    if (user != null)
                    {
                        user.Password = newpasswordTextBox.Text;
                        databaseContext.Entry(user).State = System.Data.Entity.EntityState.Modified;
                        databaseContext.SaveChanges();
                        System.Windows.Forms.MessageBox.Show("رمز عبور با موفقیت تغییر کرد ");
                    }
                }
                catch (System.Exception ex)
                {

                    System.Windows.Forms.MessageBox.Show("خطایی رخ داده است با مدیر سیستم تماس بگیرید"
                        + System.Environment.NewLine + ex.Message);
                }
                finally
                {
                    if (databaseContext != null)
                    {
                        databaseContext.Dispose();
                    }
                }
                return;
            }
        }
    }
}
