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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        UpdateProfileForm myUpdateProfileForm { get; set; }
        private void updateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((myUpdateProfileForm == null) || (myUpdateProfileForm.IsDisposed))
            {
                myUpdateProfileForm = new UpdateProfileForm()
                {
                    MdiParent = this,
                };
            }
            myUpdateProfileForm.Show();
        }
        ChangePasswordForm myChangePasswordForm { get; set; }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if((myChangePasswordForm==null)|| myChangePasswordForm.IsDisposed)
            {
                myChangePasswordForm = new ChangePasswordForm()
                {
                    MdiParent = this,
                };
            }

            myChangePasswordForm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Infrastructure.Utility.AuthenticatedUser != null)
            {
                welcomeStripStatusLabel.Text = Infrastructure.Utility.AuthenticatedUser.FullName;
            }

        }

        public void ResetForm()
        {
            adminToolStripMenuItem.Visible =
                Infrastructure.Utility.AuthenticatedUser.IsAdmin;

            string userDisplayName = Infrastructure.Utility.AuthenticatedUser.Username;

            if (string.IsNullOrWhiteSpace(Infrastructure.Utility.AuthenticatedUser.FullName) == false)
            {
                userDisplayName = Infrastructure.Utility.AuthenticatedUser.FullName;
            }
            welcomeStripStatusLabel.Text = $" welcome { userDisplayName } ";
        }
    }
}
