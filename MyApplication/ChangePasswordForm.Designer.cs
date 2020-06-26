namespace MyApplication
{
    partial class ChangePasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.oldpasswordTextBox = new System.Windows.Forms.TextBox();
            this.newpasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "&OldPassword";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "&NewPassword";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "&ConfirmPassword";
            // 
            // oldpasswordTextBox
            // 
            this.oldpasswordTextBox.Location = new System.Drawing.Point(252, 38);
            this.oldpasswordTextBox.MaxLength = 40;
            this.oldpasswordTextBox.Name = "oldpasswordTextBox";
            this.oldpasswordTextBox.Size = new System.Drawing.Size(305, 28);
            this.oldpasswordTextBox.TabIndex = 1;
            this.oldpasswordTextBox.UseSystemPasswordChar = true;
            // 
            // newpasswordTextBox
            // 
            this.newpasswordTextBox.Location = new System.Drawing.Point(252, 85);
            this.newpasswordTextBox.MaxLength = 40;
            this.newpasswordTextBox.Name = "newpasswordTextBox";
            this.newpasswordTextBox.Size = new System.Drawing.Size(305, 28);
            this.newpasswordTextBox.TabIndex = 3;
            this.newpasswordTextBox.UseSystemPasswordChar = true;
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(252, 129);
            this.confirmPasswordTextBox.MaxLength = 40;
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(305, 28);
            this.confirmPasswordTextBox.TabIndex = 5;
            this.confirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(308, 172);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(185, 45);
            this.changePasswordButton.TabIndex = 6;
            this.changePasswordButton.Text = "&ChangePassword";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // ChangePasswordForm
            // 
            this.AcceptButton = this.changePasswordButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 261);
            this.ControlBox = false;
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.newpasswordTextBox);
            this.Controls.Add(this.oldpasswordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(800, 317);
            this.MinimumSize = new System.Drawing.Size(610, 317);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oldpasswordTextBox;
        private System.Windows.Forms.TextBox newpasswordTextBox;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Button changePasswordButton;
    }
}