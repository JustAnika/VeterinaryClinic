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
            this.SuspendLayout();
            // 
            // loginLB
            // 
            this.loginLB.AutoSize = true;
            this.loginLB.Location = new System.Drawing.Point(117, 146);
            this.loginLB.Name = "loginLB";
            this.loginLB.Size = new System.Drawing.Size(36, 13);
            this.loginLB.TabIndex = 0;
            this.loginLB.Text = "Login:";
            // 
            // passwordLB
            // 
            this.passwordLB.AutoSize = true;
            this.passwordLB.Location = new System.Drawing.Point(108, 215);
            this.passwordLB.Name = "passwordLB";
            this.passwordLB.Size = new System.Drawing.Size(56, 13);
            this.passwordLB.TabIndex = 1;
            this.passwordLB.Text = "Password:";
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(69, 172);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(141, 20);
            this.loginTB.TabIndex = 2;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(69, 243);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(141, 20);
            this.passwordTB.TabIndex = 3;
            // 
            // addBT
            // 
            this.addBT.Location = new System.Drawing.Point(99, 278);
            this.addBT.Name = "addBT";
            this.addBT.Size = new System.Drawing.Size(75, 23);
            this.addBT.TabIndex = 4;
            this.addBT.Text = "Add User";
            this.addBT.UseVisualStyleBackColor = true;
            this.addBT.Click += new System.EventHandler(this.addBT_Click);
            // 
            // registerLb
            // 
            this.registerLb.AutoSize = true;
            this.registerLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registerLb.Location = new System.Drawing.Point(66, 28);
            this.registerLb.Name = "registerLb";
            this.registerLb.Size = new System.Drawing.Size(145, 24);
            this.registerLb.TabIndex = 22;
            this.registerLb.Text = "Add New User";
            // 
            // typeLB
            // 
            this.typeLB.AutoSize = true;
            this.typeLB.Location = new System.Drawing.Point(118, 65);
            this.typeLB.Name = "typeLB";
            this.typeLB.Size = new System.Drawing.Size(34, 13);
            this.typeLB.TabIndex = 23;
            this.typeLB.Text = "Type:";
            // 
            // typeLstBox
            // 
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
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 330);
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
    }
}