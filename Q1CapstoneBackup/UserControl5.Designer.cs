namespace Q1Capstone
{
    partial class UserControl5
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.userControl61 = new Q1Capstone.UserControl6();
            this.panel1 = new System.Windows.Forms.Panel();
            this.changeDetailsButton = new System.Windows.Forms.Button();
            this.usernameDisplay = new System.Windows.Forms.Label();
            this.nameDisplay = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.userControl61, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.63F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 275);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // userControl61
            // 
            this.userControl61.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl61.Location = new System.Drawing.Point(0, 100);
            this.userControl61.Margin = new System.Windows.Forms.Padding(0);
            this.userControl61.Name = "userControl61";
            this.userControl61.Size = new System.Drawing.Size(200, 175);
            this.userControl61.TabIndex = 33;
            this.userControl61.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.changeDetailsButton);
            this.panel1.Controls.Add(this.usernameDisplay);
            this.panel1.Controls.Add(this.nameDisplay);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 1;
            // 
            // changeDetailsButton
            // 
            this.changeDetailsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.changeDetailsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.changeDetailsButton.FlatAppearance.BorderSize = 0;
            this.changeDetailsButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.changeDetailsButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeDetailsButton.Location = new System.Drawing.Point(13, 74);
            this.changeDetailsButton.Name = "changeDetailsButton";
            this.changeDetailsButton.Size = new System.Drawing.Size(175, 20);
            this.changeDetailsButton.TabIndex = 32;
            this.changeDetailsButton.Text = "Change Account Details";
            this.changeDetailsButton.UseVisualStyleBackColor = false;
            this.changeDetailsButton.Click += new System.EventHandler(this.changeDetailsButton_Click);
            // 
            // usernameDisplay
            // 
            this.usernameDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameDisplay.Location = new System.Drawing.Point(81, 28);
            this.usernameDisplay.Name = "usernameDisplay";
            this.usernameDisplay.Size = new System.Drawing.Size(100, 13);
            this.usernameDisplay.TabIndex = 31;
            this.usernameDisplay.Text = "_____";
            // 
            // nameDisplay
            // 
            this.nameDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameDisplay.Location = new System.Drawing.Point(81, 8);
            this.nameDisplay.Name = "nameDisplay";
            this.nameDisplay.Size = new System.Drawing.Size(100, 13);
            this.nameDisplay.TabIndex = 30;
            this.nameDisplay.Text = "_____";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(40, 8);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 29;
            this.nameLabel.Text = "Name:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(20, 28);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 28;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.Location = new System.Drawing.Point(81, 48);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 27;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(22, 49);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 24;
            this.passwordLabel.Text = "Password:";
            // 
            // UserControl5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl5";
            this.Size = new System.Drawing.Size(200, 275);
            this.VisibleChanged += new System.EventHandler(this.UserControl5_VisibleChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UserControl6 userControl61;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button changeDetailsButton;
        private System.Windows.Forms.Label usernameDisplay;
        private System.Windows.Forms.Label nameDisplay;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
    }
}
