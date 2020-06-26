
using System;
using System.Linq;
namespace MyApplication
{
    public partial class UpdateProfileForm : Infrastructure.BaseForm
    {
        public UpdateProfileForm()
        {
            InitializeComponent();
        }

        private void UpdateProfileForm_Load(object sender, System.EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;
            try
            {
                databaseContext = new Models.DatabaseContext();
                Models.User user = databaseContext.Users
                    .Where(x => x.Id == Infrastructure.Utility.AuthenticatedUser.Id)
                    .FirstOrDefault();
                if (user == null)
                {
                    System.Windows.Forms.MessageBox.Show("خطایی رخ داده است با مدیر سیستم تماس بگیرید");
                    //System.Windows.Forms.Application.Exit();
                }

                fullnameTextBox.Text = user.FullName;
                descriptionTextBox.Text = user.Description;
            }
            catch (System.Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("خطایی رخ داده است با مدیر سیستم تماس بگیرید"
                    + Environment.NewLine + ex.Message);
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fullnameTextBox.Text) || string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {

            }
            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext = new Models.DatabaseContext();

                Models.User user = databaseContext.Users
                    .Find(Infrastructure.Utility.AuthenticatedUser.Id);
                if (user == null)
                {
                    System.Windows.Forms.MessageBox.Show("خطایی رخ داده است با مدیر سیستم تماس بگیرید");
                }
                else
                {
                    user.FullName = fullnameTextBox.Text;
                    user.Description = descriptionTextBox.Text;
                    databaseContext.Entry(user).State = System.Data.Entity.EntityState.Modified;
                    databaseContext.SaveChanges();

                    Infrastructure.Utility.AuthenticatedUser = user;
                    ResetForm();
                    System.Windows.Forms.MessageBox.Show("اطلاعات با موفقیت ویرایش شد ");
                }
            }
            catch (System.Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("خطایی رخ داده است با مدیر سیستم تماس بگیرید"
                    + Environment.NewLine + ex.Message);
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                }
            }
        }

        public void ResetForm()
        {
            fullnameTextBox.Text = Infrastructure.Utility.AuthenticatedUser.FullName;
            descriptionTextBox.Text = Infrastructure.Utility.AuthenticatedUser.Description;
        }
    }
}
