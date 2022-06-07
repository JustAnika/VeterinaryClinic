namespace PAzIG
{
    partial class LogIn
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginBT = new System.Windows.Forms.Button();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.nameLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginBT
            // 
            this.loginBT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginBT.BackColor = System.Drawing.Color.Yellow;
            this.loginBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginBT.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.loginBT.FlatAppearance.BorderSize = 0;
            this.loginBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.loginBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.loginBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(4)))), ((int)(((byte)(157)))));
            this.loginBT.Location = new System.Drawing.Point(99, 167);
            this.loginBT.Name = "loginBT";
            this.loginBT.Size = new System.Drawing.Size(92, 35);
            this.loginBT.TabIndex = 0;
            this.loginBT.Text = "Log In";
            this.loginBT.UseVisualStyleBackColor = false;
            this.loginBT.Click += new System.EventHandler(this.loginBT_Click);
            // 
            // loginTB
            // 
            this.loginTB.AllowDrop = true;
            this.loginTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginTB.BackColor = System.Drawing.SystemColors.Info;
            this.loginTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(4)))), ((int)(((byte)(157)))));
            this.loginTB.Location = new System.Drawing.Point(45, 72);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(203, 20);
            this.loginTB.TabIndex = 3;
            // 
            // passwordTB
            // 
            this.passwordTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTB.BackColor = System.Drawing.SystemColors.Info;
            this.passwordTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(4)))), ((int)(((byte)(157)))));
            this.passwordTB.Location = new System.Drawing.Point(45, 121);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(203, 20);
            this.passwordTB.TabIndex = 4;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // nameLB
            // 
            this.nameLB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nameLB.AutoSize = true;
            this.nameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLB.ForeColor = System.Drawing.Color.Yellow;
            this.nameLB.Location = new System.Drawing.Point(42, 28);
            this.nameLB.Name = "nameLB";
            this.nameLB.Size = new System.Drawing.Size(206, 16);
            this.nameLB.TabIndex = 6;
            this.nameLB.Text = "Welcome to veterinary clinic!";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(4)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(292, 235);
            this.Controls.Add(this.nameLB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.loginBT);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(24)))), ((int)(((byte)(205)))));
            this.Name = "LogIn";
            this.Text = "Vet Clinic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogIn_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBT;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label nameLB;
    }
}

