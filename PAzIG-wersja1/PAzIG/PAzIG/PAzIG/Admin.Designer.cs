namespace PAzIG
{
    partial class Admin
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
            this.loginLB = new System.Windows.Forms.Label();
            this.passwordLB = new System.Windows.Forms.Label();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.addBT = new System.Windows.Forms.Button();
            this.registerLb = new System.Windows.Forms.Label();
            this.typeLB = new System.Windows.Forms.Label();
            this.typeLstBox = new System.Windows.Forms.CheckedListBox();
            this.backBT = new System.Windows.Forms.Button();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.lastNameLb = new System.Windows.Forms.Label();
            this.firstNameLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginLB
            // 
            this.loginLB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.loginLB.AutoSize = true;
            this.loginLB.ForeColor = System.Drawing.Color.Yellow;
            this.loginLB.Location = new System.Drawing.Point(117, 300);
            this.loginLB.Name = "loginLB";
            this.loginLB.Size = new System.Drawing.Size(40, 13);
            this.loginLB.TabIndex = 0;
            this.loginLB.Text = "Login:*";
            // 
            // passwordLB
            // 
            this.passwordLB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.passwordLB.AutoSize = true;
            this.passwordLB.ForeColor = System.Drawing.Color.Yellow;
            this.passwordLB.Location = new System.Drawing.Point(108, 369);
            this.passwordLB.Name = "passwordLB";
            this.passwordLB.Size = new System.Drawing.Size(60, 13);
            this.passwordLB.TabIndex = 1;
            this.passwordLB.Text = "Password:*";
            // 
            // loginTB
            // 
            this.loginTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginTB.BackColor = System.Drawing.SystemColors.Info;
            this.loginTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(4)))), ((int)(((byte)(157)))));
            this.loginTB.Location = new System.Drawing.Point(69, 326);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(141, 20);
            this.loginTB.TabIndex = 2;
            // 
            // passwordTB
            // 
            this.passwordTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTB.BackColor = System.Drawing.SystemColors.Info;
            this.passwordTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(4)))), ((int)(((byte)(157)))));
            this.passwordTB.Location = new System.Drawing.Point(69, 397);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(141, 20);
            this.passwordTB.TabIndex = 3;
            // 
            // addBT
            // 
            this.addBT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addBT.BackColor = System.Drawing.Color.Yellow;
            this.addBT.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.addBT.FlatAppearance.BorderSize = 0;
            this.addBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.addBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.addBT.Location = new System.Drawing.Point(30, 438);
            this.addBT.Name = "addBT";
            this.addBT.Size = new System.Drawing.Size(75, 23);
            this.addBT.TabIndex = 4;
            this.addBT.Text = "Add User";
            this.addBT.UseVisualStyleBackColor = false;
            this.addBT.Click += new System.EventHandler(this.addBT_Click);
            // 
            // registerLb
            // 
            this.registerLb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.registerLb.AutoSize = true;
            this.registerLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registerLb.ForeColor = System.Drawing.Color.Yellow;
            this.registerLb.Location = new System.Drawing.Point(66, 28);
            this.registerLb.Name = "registerLb";
            this.registerLb.Size = new System.Drawing.Size(145, 24);
            this.registerLb.TabIndex = 22;
            this.registerLb.Text = "Add New User";
            // 
            // typeLB
            // 
            this.typeLB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.typeLB.AutoSize = true;
            this.typeLB.ForeColor = System.Drawing.Color.Yellow;
            this.typeLB.Location = new System.Drawing.Point(118, 65);
            this.typeLB.Name = "typeLB";
            this.typeLB.Size = new System.Drawing.Size(34, 13);
            this.typeLB.TabIndex = 23;
            this.typeLB.Text = "Type:";
            // 
            // typeLstBox
            // 
            this.typeLstBox.BackColor = System.Drawing.SystemColors.Info;
            this.typeLstBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(4)))), ((int)(((byte)(157)))));
            this.typeLstBox.FormattingEnabled = true;
            this.typeLstBox.Items.AddRange(new object[] {
            "Doctor",
            "Nurse",
            "Technician"});
            this.typeLstBox.Location = new System.Drawing.Point(69, 85);
            this.typeLstBox.Name = "typeLstBox";
            this.typeLstBox.Size = new System.Drawing.Size(141, 49);
            this.typeLstBox.TabIndex = 24;
            // 
            // backBT
            // 
            this.backBT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backBT.BackColor = System.Drawing.Color.Yellow;
            this.backBT.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.backBT.FlatAppearance.BorderSize = 0;
            this.backBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.backBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.backBT.Location = new System.Drawing.Point(157, 438);
            this.backBT.Name = "backBT";
            this.backBT.Size = new System.Drawing.Size(75, 23);
            this.backBT.TabIndex = 25;
            this.backBT.Text = "Go Back";
            this.backBT.UseVisualStyleBackColor = false;
            this.backBT.Click += new System.EventHandler(this.backBT_Click);
            // 
            // lastNameTB
            // 
            this.lastNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTB.BackColor = System.Drawing.SystemColors.Info;
            this.lastNameTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(4)))), ((int)(((byte)(157)))));
            this.lastNameTB.Location = new System.Drawing.Point(69, 254);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(141, 20);
            this.lastNameTB.TabIndex = 29;
            // 
            // firstNameTB
            // 
            this.firstNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameTB.BackColor = System.Drawing.SystemColors.Info;
            this.firstNameTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(4)))), ((int)(((byte)(157)))));
            this.firstNameTB.Location = new System.Drawing.Point(69, 183);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(141, 20);
            this.firstNameTB.TabIndex = 28;
            // 
            // lastNameLb
            // 
            this.lastNameLb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lastNameLb.AutoSize = true;
            this.lastNameLb.ForeColor = System.Drawing.Color.Yellow;
            this.lastNameLb.Location = new System.Drawing.Point(108, 226);
            this.lastNameLb.Name = "lastNameLb";
            this.lastNameLb.Size = new System.Drawing.Size(65, 13);
            this.lastNameLb.TabIndex = 27;
            this.lastNameLb.Text = "Last Name:*";
            // 
            // firstNameLb
            // 
            this.firstNameLb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.firstNameLb.AutoSize = true;
            this.firstNameLb.ForeColor = System.Drawing.Color.Yellow;
            this.firstNameLb.Location = new System.Drawing.Point(108, 158);
            this.firstNameLb.Name = "firstNameLb";
            this.firstNameLb.Size = new System.Drawing.Size(64, 13);
            this.firstNameLb.TabIndex = 26;
            this.firstNameLb.Text = "First Name:*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(30, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "*required information";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(4)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(272, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.lastNameLb);
            this.Controls.Add(this.firstNameLb);
            this.Controls.Add(this.backBT);
            this.Controls.Add(this.typeLstBox);
            this.Controls.Add(this.typeLB);
            this.Controls.Add(this.registerLb);
            this.Controls.Add(this.addBT);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.passwordLB);
            this.Controls.Add(this.loginLB);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLB;
        private System.Windows.Forms.Label passwordLB;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button addBT;
        private System.Windows.Forms.Label registerLb;
        private System.Windows.Forms.Label typeLB;
        private System.Windows.Forms.CheckedListBox typeLstBox;
        private System.Windows.Forms.Button backBT;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.Label lastNameLb;
        private System.Windows.Forms.Label firstNameLb;
        private System.Windows.Forms.Label label1;
    }
}