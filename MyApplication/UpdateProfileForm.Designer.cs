namespace MyApplication
{
    partial class UpdateProfileForm
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
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.fullnameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Location = new System.Drawing.Point(49, 25);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(88, 20);
            this.fullnameLabel.TabIndex = 0;
            this.fullnameLabel.Text = "&Fullname";
            // 
            // fullnameTextBox
            // 
            this.fullnameTextBox.Location = new System.Drawing.Point(185, 22);
            this.fullnameTextBox.Name = "fullnameTextBox";
            this.fullnameTextBox.Size = new System.Drawing.Size(263, 28);
            this.fullnameTextBox.TabIndex = 1;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(49, 73);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(106, 20);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "&Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(185, 66);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(263, 159);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(260, 241);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(109, 33);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "&Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // UpdateProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.fullnameTextBox);
            this.Controls.Add(this.fullnameLabel);
            this.Name = "UpdateProfileForm";
            this.Text = "UpdateProfileForm";
            this.Load += new System.EventHandler(this.UpdateProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fullnameLabel;
        private System.Windows.Forms.TextBox fullnameTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button updateButton;
    }
}