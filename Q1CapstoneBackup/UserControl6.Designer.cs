namespace Q1Capstone
{
    partial class UserControl6
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newNameBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordBox = new System.Windows.Forms.TextBox();
            this.newPasswordBox = new System.Windows.Forms.TextBox();
            this.newUsernameBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.changeNameButton = new System.Windows.Forms.Button();
            this.changeUsernameButton = new System.Windows.Forms.Button();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newNameBox
            // 
            this.newNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newNameBox.Location = new System.Drawing.Point(3, 25);
            this.newNameBox.Name = "newNameBox";
            this.newNameBox.Size = new System.Drawing.Size(100, 20);
            this.newNameBox.TabIndex = 10;
            this.newNameBox.TextChanged += new System.EventHandler(this.newNameBox_TextChanged);
            // 
            // confirmPasswordBox
            // 
            this.confirmPasswordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmPasswordBox.Location = new System.Drawing.Point(3, 145);
            this.confirmPasswordBox.Name = "confirmPasswordBox";
            this.confirmPasswordBox.PasswordChar = '*';
            this.confirmPasswordBox.Size = new System.Drawing.Size(100, 20);
            this.confirmPasswordBox.TabIndex = 15;
            this.confirmPasswordBox.TextChanged += new System.EventHandler(this.confirmPasswordBox_TextChanged);
            // 
            // newPasswordBox
            // 
            this.newPasswordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newPasswordBox.Location = new System.Drawing.Point(3, 105);
            this.newPasswordBox.Name = "newPasswordBox";
            this.newPasswordBox.PasswordChar = '*';
            this.newPasswordBox.Size = new System.Drawing.Size(100, 20);
            this.newPasswordBox.TabIndex = 14;
            this.newPasswordBox.TextChanged += new System.EventHandler(this.newPasswordBox_TextChanged);
            // 
            // newUsernameBox
            // 
            this.newUsernameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newUsernameBox.Location = new System.Drawing.Point(3, 65);
            this.newUsernameBox.Name = "newUsernameBox";
            this.newUsernameBox.Size = new System.Drawing.Size(100, 20);
            this.newUsernameBox.TabIndex = 12;
            this.newUsernameBox.TextChanged += new System.EventHandler(this.newUsernameBox_TextChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(3, 50);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(83, 13);
            this.usernameLabel.TabIndex = 11;
            this.usernameLabel.Text = "New Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(3, 90);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(81, 13);
            this.passwordLabel.TabIndex = 13;
            this.passwordLabel.Text = "New Password:";
            // 
            // confirmLabel
            // 
            this.confirmLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Location = new System.Drawing.Point(3, 130);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(94, 13);
            this.confirmLabel.TabIndex = 15;
            this.confirmLabel.Text = "Confirm Password:";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(3, 10);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(63, 13);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "New Name:";
            // 
            // changeNameButton
            // 
            this.changeNameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.changeNameButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.changeNameButton.FlatAppearance.BorderSize = 0;
            this.changeNameButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.changeNameButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeNameButton.Location = new System.Drawing.Point(109, 10);
            this.changeNameButton.Name = "changeNameButton";
            this.changeNameButton.Size = new System.Drawing.Size(88, 35);
            this.changeNameButton.TabIndex = 11;
            this.changeNameButton.Text = "Change Name";
            this.changeNameButton.UseVisualStyleBackColor = false;
            this.changeNameButton.Click += new System.EventHandler(this.changeNameButton_Click);
            // 
            // changeUsernameButton
            // 
            this.changeUsernameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.changeUsernameButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.changeUsernameButton.FlatAppearance.BorderSize = 0;
            this.changeUsernameButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.changeUsernameButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeUsernameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeUsernameButton.Location = new System.Drawing.Point(109, 50);
            this.changeUsernameButton.Name = "changeUsernameButton";
            this.changeUsernameButton.Size = new System.Drawing.Size(88, 35);
            this.changeUsernameButton.TabIndex = 13;
            this.changeUsernameButton.Text = "Change Username";
            this.changeUsernameButton.UseVisualStyleBackColor = false;
            this.changeUsernameButton.Click += new System.EventHandler(this.changeUsernameButton_Click);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.changePasswordButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.changePasswordButton.FlatAppearance.BorderSize = 0;
            this.changePasswordButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.changePasswordButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePasswordButton.Location = new System.Drawing.Point(109, 90);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(88, 35);
            this.changePasswordButton.TabIndex = 16;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = false;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(109, 130);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(88, 35);
            this.closeButton.TabIndex = 17;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // UserControl6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.changeUsernameButton);
            this.Controls.Add(this.changeNameButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.newNameBox);
            this.Controls.Add(this.confirmPasswordBox);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.newPasswordBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.newUsernameBox);
            this.Name = "UserControl6";
            this.Size = new System.Drawing.Size(200, 175);
            this.VisibleChanged += new System.EventHandler(this.UserControl6_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newNameBox;
        private System.Windows.Forms.TextBox confirmPasswordBox;
        private System.Windows.Forms.TextBox newPasswordBox;
        private System.Windows.Forms.TextBox newUsernameBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button changeNameButton;
        private System.Windows.Forms.Button changeUsernameButton;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Button closeButton;
    }
}
