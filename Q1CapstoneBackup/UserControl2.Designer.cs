namespace Q1Capstone
{
    partial class UserControl2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.absentButton = new System.Windows.Forms.Button();
            this.presentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tardyButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.absentButton);
            this.panel1.Controls.Add(this.presentButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tardyButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 78);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // absentButton
            // 
            this.absentButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.absentButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.absentButton.FlatAppearance.BorderSize = 0;
            this.absentButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.absentButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.absentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.absentButton.Location = new System.Drawing.Point(177, 37);
            this.absentButton.Name = "absentButton";
            this.absentButton.Size = new System.Drawing.Size(80, 30);
            this.absentButton.TabIndex = 4;
            this.absentButton.Text = "Absent";
            this.absentButton.UseVisualStyleBackColor = false;
            this.absentButton.Click += new System.EventHandler(this.absentButton_Click);
            // 
            // presentButton
            // 
            this.presentButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.presentButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.presentButton.FlatAppearance.BorderSize = 0;
            this.presentButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.presentButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.presentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.presentButton.Location = new System.Drawing.Point(5, 37);
            this.presentButton.Name = "presentButton";
            this.presentButton.Size = new System.Drawing.Size(80, 30);
            this.presentButton.TabIndex = 2;
            this.presentButton.Text = "Present";
            this.presentButton.UseVisualStyleBackColor = false;
            this.presentButton.Click += new System.EventHandler(this.presentButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Student Name:";
            // 
            // tardyButton
            // 
            this.tardyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tardyButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tardyButton.FlatAppearance.BorderSize = 0;
            this.tardyButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tardyButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tardyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tardyButton.Location = new System.Drawing.Point(91, 37);
            this.tardyButton.Name = "tardyButton";
            this.tardyButton.Size = new System.Drawing.Size(80, 30);
            this.tardyButton.TabIndex = 3;
            this.tardyButton.Text = "Tardy";
            this.tardyButton.UseVisualStyleBackColor = false;
            this.tardyButton.Click += new System.EventHandler(this.tardyButton_Click);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(262, 78);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button absentButton;
        private System.Windows.Forms.Button presentButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tardyButton;
    }
}
